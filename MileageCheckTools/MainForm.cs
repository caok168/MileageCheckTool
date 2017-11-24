using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeoFileProcess;
using GeoFileProcess.Model;
using MileageCheckTools.Model;
using MileageCheckTools.DAL;
using MileageCheckTools.Common;
using System.Threading.Tasks;

namespace MileageCheckTools
{
    public partial class MainForm : Form
    {
        GeoFileHelper geoHelper = new GeoFileHelper();

        string folderPath = "";
        IOperator _dbOperator = null;
        private string geoFilePath = "";
        private string geoFileName = "";
        //线路总长度(km)
        private double totalLength = 0;

        List<JumpPoints> listPoints = new List<JumpPoints>();

        public MainForm()
        {
            InitializeComponent();
        }

        

        /// <summary>
        /// 选择GEO文件按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectGEO_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = "";
                DialogResult dr = openFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    totalLength = -1;
                    geoFilePath = openFileDialog1.FileName;

                    geoFileName = geoFilePath.Substring(geoFilePath.LastIndexOf("\\") + 1);

                    toolStripStatusLabel2.Text = geoFilePath;
                    toolStripStatusLabel2.Width = statusStrip1.Width - toolStripStatusLabel1.Width;

                    btnReadGeo.Enabled = true;
                    btnWriteData.Enabled = true;

                    var header = geoHelper.GetDataInfoHead(geoFilePath);

                    if (header != null)
                    {
                        this.txtLineName.Text = header.region;
                        
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message);
            }
        }

        /// <summary>
        /// 读取跳变点按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadGeo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(geoFilePath))
            {
                MessageBox.Show("请选择Geo文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                btnReadGeo.Enabled = false;
                btnReadGeo.Cursor = Cursors.Default;
                progressBar1.Location = new Point(this.Width / 2 - progressBar1.Width / 2, this.Height / 2 - progressBar1.Height);
                progressBar1.Visible = true;

                Task t = Task.Factory.StartNew(() =>
                {
                    ProcessGeoFile();
                    this.Invoke(new Action(() => {
                        DisplayGrid(listPoints);
                        btnReadGeo.Enabled = true;
                    }));
                });
                t.ContinueWith((task) =>
                {
                    if (task.Exception != null)
                    {
                        MessageBox.Show("错误：" + task.Exception.InnerException.Message);
                    }
                   
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show("处理文件出错：" + ex.Message);
            }
            //try
            //{
            //    DisplayGrid(listPoints);
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("显示数据出错:" + ex.Message);
            //}
        }

        /// <summary>
        /// 保存索引点按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWriteData_Click(object sender, EventArgs e)
        {

            try
            {
                if (listPoints.Count > 0)
                {
                    btnWriteData.Enabled = false;
                    TotalFileDAL totalFileDal = new TotalFileDAL(folderPath);
                    TotalFile file = new TotalFile();
                    file.TotalLength = totalLength;
                    file.LineName = this.txtLineName.Text.Trim();
                    if (cbxTrain.SelectedItem != null && !string.IsNullOrEmpty(cbxTrain.SelectedItem.ToString()))
                    {
                        file.TrainCode = this.cbxTrain.SelectedItem.ToString();
                    }
                    file.GeoFileName = geoFileName;
                    file.ResultTableName = "Result" + file.LineName + file.TrainCode + DateTime.Now.ToString("yyyyMMddHHmmss");


                    totalFileDal.Add(file);

                    JumpPointsDAL jumpDal = new JumpPointsDAL(folderPath);

                    jumpDal.CreateTable(folderPath, file.ResultTableName);
                    jumpDal.DeleteAll(file.ResultTableName);
                    for (int i = 0; i < listPoints.Count; i++)
                    {
                        jumpDal.Add(listPoints[i], file.ResultTableName);
                    }
                    MessageBox.Show("保存完成！");
                    btnWriteData.Enabled = true;
                }
                else
                {
                    MessageBox.Show("不存在跳变点，请先计算！");
                }
            }
            catch(Exception  ex)
            {
                btnWriteData.Enabled = true;
                MessageBox.Show("保存数据出错：" + ex.Message);
            }
        }

        /// <summary>
        /// 查看按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewResult_Click(object sender, EventArgs e)
        {
            try
            {
                TotalFile file = new TotalFile();
                file.LineName = this.txtLineName.Text.Trim();
                if (cbxTrain.SelectedItem != null && !string.IsNullOrEmpty(cbxTrain.SelectedItem.ToString()))
                {
                    file.TrainCode = this.cbxTrain.SelectedItem.ToString().Replace("-", "_");
                }
                else
                {
                    file.TrainCode = "";
                }
                file.GeoFileName = geoFileName;
                ResultViewForm from = new ResultViewForm(file);
                from.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message);
            }
        }



        private void ProcessGeoFile()
        {
            this.Invoke(new Action(() =>
            {
                progressBar1.Value = 1;
                
            }));
            List<int[]> dataList = geoHelper.GetMileChannelData(geoFilePath);

            totalLength = (dataList[1].Length - 1) * 0.25 / 1000;

            this.Invoke(new Action(() =>
            {
                progressBar1.Value = 8;

            }));

            double km_pre = 0;
            double meter_pre = 0;
            double km_currrent = 0;
            double meter_current = 0;
            double mileage_between = 0;
            double meter_between = 0;

            double mileage_pre=0;
            double mileage_current=0;

            double forwardValue = 0;
            double backValue = 0;

            try
            {
                if (dataList != null && dataList.Count > 0)
                {
                    listPoints.Clear();
                    int index = 0;
                    for (int i = 0; i < dataList[0].Length; i++)
                    {
                        if (i == 0)
                        {
                            km_pre = dataList[0][i];
                            meter_pre = dataList[1][i];
                        }
                        else
                        {
                            km_currrent = dataList[0][i];
                            meter_current = dataList[1][i];

                            mileage_pre = km_pre * 1000 + meter_pre * 0.25;
                            mileage_current = km_currrent * 1000 + meter_current * 0.25;

                            mileage_between = mileage_current - mileage_pre;
                            meter_between = meter_current - meter_pre;

                            if (Math.Abs(mileage_between) > Convert.ToDouble(numUDJumpValue.Value))
                            {
                                if (mileage_between > forwardValue)
                                {
                                    forwardValue = mileage_between;
                                }
                                if (mileage_between < 0 && Math.Abs(mileage_between) > backValue)
                                {
                                    backValue = Math.Abs(mileage_between);
                                }

                                JumpPoints point = new JumpPoints();
                                point.ID = ++index;
                                point.CurrentMileage = km_currrent;
                                point.CurrentSample = meter_current;
                                point.LastMileage = km_pre;
                                point.LastSample = meter_pre;
                                point.DiffMileage = mileage_between;
                                point.DiffSample = meter_between;

                                listPoints.Add(point);
                            }

                            km_pre = km_currrent;
                            meter_pre = meter_current;
                            int value = i * 80 / dataList[0].Length;
                            if (value != 0 && (value % 20 == 0) || i == dataList[0].Length - 1)
                            {
                                this.Invoke(new Action(() =>
                                {
                                    progressBar1.Value = value;
                                    if (i == dataList[0].Length - 1)
                                    {
                                        progressBar1.Visible = false;
                                    }
                                }));

                            }
                        }
                        
                    }

                }
                else
                {
                    MessageBox.Show("没有获取到Geo通道数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统错误" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void DisplayGrid(List<JumpPoints> list)
        {
            if (list.Count > 0)
            {
                double avgValue1 = list.Sum(s => s.DiffMileage) / totalLength;
                double avgValue2 = list.Sum(s => Math.Abs(s.DiffMileage)) / list.Count;

                this.textBox1.Text = list.Max(p => p.DiffSample).ToString();
                this.textBox2.Text = list.Min(p => p.DiffSample).ToString();
                this.textBox3.Text = avgValue2.ToString("F5");
                this.textBox4.Text = avgValue1.ToString("F5");
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = list;

            }
            else
            {
                MessageBox.Show("没有找到跳变点！");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                folderPath = Application.StartupPath + "\\Result.mdb";
                _dbOperator = new DbOperator();
                _dbOperator.DbFilePath = folderPath;
                DataTable dt = _dbOperator.Query("select * from TrackMode");
                List<string> carNo = new List<string>();
                carNo.Add("");
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        carNo.Add(dt.Rows[i]["TrainNO"].ToString());
                    }
                }
                //cbxTrain.DisplayMember = "TrainNO";
                cbxTrain.DataSource = carNo;
            }
            catch(Exception ex)
            {
                MessageBox.Show("加载数据出错：" + ex.Message);
            }

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("跳变结果中最大的Sample值", textBox1);
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("跳变结果中最小的Sample值", textBox2);
        }

        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("所有跳变点的采样差之和除以线路总长度(公里)", textBox4);
        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("所有跳变点的采样差的绝对值之和除以跳变总个数", textBox3);
        }

        private void textBoxAll_MouseLeave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            toolTip1.Hide(txt);
        }
    }
}

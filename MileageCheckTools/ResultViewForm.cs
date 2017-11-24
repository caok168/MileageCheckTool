using MileageCheckTools.Common;
using MileageCheckTools.DAL;
using MileageCheckTools.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MileageCheckTools
{
    public partial class ResultViewForm : Form
    {
        TotalFile _totalFile = new TotalFile();

        string tableName = "";

        public ResultViewForm(TotalFile totalFile)
        {
            InitializeComponent();
            _totalFile = totalFile;
        }

        IOperator _dbOperator = null;

        JumpPointsDAL _jumpDal = null;
        TotalFileDAL _totalFileDal = null;

        ChartConfig _chartScatterConfig = new ChartConfig();
        ChartConfig _chartColumnConfig = new ChartConfig();

        ChartConfig _chartJumpConfig = new ChartConfig();
        
        List<JumpPoints> jumpPoints = new List<JumpPoints>();

        private void ResultViewForm_Load(object sender, EventArgs e)
        {
            dgvResult.AutoGenerateColumns = false;
            dgvData.AutoGenerateColumns = false;
            _dbOperator = new DbOperator();
            _dbOperator.DbFilePath = Application.StartupPath + "\\Result.mdb";

            _jumpDal = new JumpPointsDAL(_dbOperator.DbFilePath);

            _totalFileDal = new TotalFileDAL(_dbOperator.DbFilePath);
            BindResultData();
            jumpPoints.Clear();
            _chartScatterConfig.AxesXStep = 10;
            _chartScatterConfig.AxesYStep = 50;
            _chartScatterConfig.ChartTitle = "跳变值散点图";
            _chartScatterConfig.AxesXTitle = "里程";
            _chartScatterConfig.AxesYTitle = "采样点差值";

            _chartColumnConfig.AxesXMin = -400;
            _chartColumnConfig.AxesXStep = 10;
            _chartColumnConfig.AxesXMax = 400;
            _chartColumnConfig.AxesYMin = 0;
            _chartColumnConfig.AxesYStep = 1;
            _chartColumnConfig.ChartTitle = "跳变值柱状图";
            _chartColumnConfig.AxesXTitle = "差值区间";
            _chartColumnConfig.AxesYTitle = "跳变点个数";
        }

        private void BindResultData()
        {
            List<TotalFile> totalData = _totalFileDal.GetList(_totalFile.LineName, _totalFile.TrainCode);
            dgvResult.DataSource = null;
            dgvResult.Rows.Clear();
            //var table = totalData.AsEnumerable();
            //if (!string.IsNullOrEmpty(_totalFile.LineName))
            //{
            //    table = from r in table
            //            where r.LineName == _totalFile.LineName
            //            select r;
            //}
            //if (!string.IsNullOrEmpty(_totalFile.TrainCode))
            //{
            //    table = from r in table
            //            where r.TrainCode == _totalFile.TrainCode
            //            select r;
            //}
            if (totalData.Count > 0)
            {
                dgvResult.DataSource = totalData;
            }
            else
            {
                Task.Factory.StartNew(() =>
                {
                    Thread.Sleep(200);
                    MessageBox.Show("未找到数据");
                });

            }
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            calcDgvResult();
        }

        private void calcDgvResult() {
            try
            {
                if (dgvResult.SelectedRows != null && dgvResult.SelectedRows.Count > 0)
                {
                    jumpPoints.Clear();
                    tableName = dgvResult.SelectedRows[0].Cells[3].Value.ToString();
                    double totalLength = Convert.ToDouble(dgvResult.SelectedRows[0].Cells[4].Value);
                    jumpPoints = _jumpDal.Load(tableName);
                    if (jumpPoints.Count > 0)
                    {

                        dgvData.DataSource = null;
                        dgvData.Rows.Clear();
                        dgvData.DataSource = jumpPoints;

                        txtMaxForward.Text = jumpPoints.Max(p => p.DiffSample).ToString();
                        txtMaxNegative.Text = jumpPoints.Min(p => p.DiffSample).ToString();
                        double arr = jumpPoints.Sum(p => p.DiffSample) / totalLength;
                        double arr1 = jumpPoints.Sum(p => Math.Abs(p.DiffSample)) / jumpPoints.Count;
                        txtAverage.Text = arr.ToString("F5");
                        txtAbsoluteAverage.Text = arr1.ToString("F5");


                        int[] dataX = jumpPoints.Select(p => (int)p.CurrentMileage).ToList().Distinct().ToArray();
                        double[] dataY = jumpPoints.Select(p => p.DiffSample).ToArray();
                        _chartScatterConfig.AxesXMin = dataX.Min();
                        _chartScatterConfig.AxesXMax = dataX.Max();
                        _chartScatterConfig.AxesYMin = dataY.Min();
                        _chartScatterConfig.AxesYMax = dataY.Max();
                        CreateScatterChart();
                        CreateColumnChart();


                        //_chartJumpConfig.AxesXMin = -400;
                        //_chartJumpConfig.AxesXMax = 1000;
                        //_chartJumpConfig.AxesXMin = 0;
                        _chartJumpConfig.AxesXStep = 100;
                        _chartJumpConfig.AxesYMin = -400;
                        _chartJumpConfig.AxesYMax = 400;
                        //_chartJumpConfig.AxesYStep = 1;
                        _chartJumpConfig.AxesXStep = 30;
                        _chartJumpConfig.AxesYStep = 200;
                        _chartJumpConfig.ChartTitle = "跳变值柱状图2";
                        _chartJumpConfig.AxesXTitle = "里程";
                        _chartJumpConfig.AxesYTitle = "采样点差值";

                        _chartJumpConfig.AxesXMin = dataX.Min();
                        _chartJumpConfig.AxesXMax = dataX.Max();
                        //_chartJumpConfig.AxesYMin = dataY.Min();
                        //_chartJumpConfig.AxesYMax = dataY.Max();
                        CreateJumpChart();
                    }
                    else
                    {
                        MessageBox.Show("没有找到数据");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message);
            }
        }


        private bool CreateScatterChart()
        {
            try
            {
                int[] dataX = jumpPoints.Select(p => (int)p.CurrentMileage).ToList().Distinct().ToArray();
                double[] dataY = jumpPoints.Select(p => p.DiffSample).ToArray();
                chart1.Titles.Clear();
                chart1.Series.Clear();
                Title tile = new Title(_chartScatterConfig.ChartTitle);
                tile.Font = _chartScatterConfig.ChartTitleFont;
                chart1.AntiAliasing = AntiAliasingStyles.Graphics;
                chart1.Titles.Add(tile);
                Series s1 = new Series();
                s1.ChartType = SeriesChartType.Point;
                s1.IsVisibleInLegend = false;
                chart1.BorderlineColor = Color.Black;
                chart1.BorderSkin = new BorderSkin();
                chart1.BorderSkin.BorderWidth = 2;
                chart1.ChartAreas[0].AxisX.Minimum = _chartScatterConfig.AxesXMin;
                //chart1.ChartAreas[0].AxisX.Interval = _chartScatterConfig.AxesXStep;
                chart1.ChartAreas[0].AxisX.Title = _chartScatterConfig.AxesXTitle;
                chart1.ChartAreas[0].AxisX.TitleFont = _chartScatterConfig.AxesXFont;

                //chart1.ChartAreas[0].AxisY.Interval = _chartScatterConfig.AxesYStep;
                chart1.ChartAreas[0].AxisY.Minimum = _chartScatterConfig.AxesYMin;
                chart1.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
                chart1.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;

                chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
                chart1.ChartAreas[0].AxisY.Title = _chartScatterConfig.AxesYTitle;
                chart1.ChartAreas[0].AxisY.TitleFont = _chartScatterConfig.AxesYFont;
                for (int i = 0; i < dataX.Length; i++)
                {
                    s1.Points.AddXY(dataX[i],dataY[i]);
                    //if(dataX[i])
                    //s1.Points[i].AxisLabel = dataX[i]
                }
                s1.MarkerStyle = new MarkerStyle();
                s1.MarkerSize = 3;
                s1.MarkerColor = Color.Blue;
                chart1.Series.Add(s1);
                chart1.SaveImage(Application.StartupPath + "\\散点图.jpg", ChartImageFormat.Jpeg);
                return true;
            }
            catch (Exception)
            {
                chart1.Titles.Clear();
                chart1.Series.Clear();
                return false;
            }
        }

        private bool CreateColumnChart()
        {
            try
            {
                double lastMin = _chartColumnConfig.AxesXMin;
                int count = (int)((_chartColumnConfig.AxesXMax - _chartColumnConfig.AxesXMin) / _chartColumnConfig.AxesXStep);
                int[][] barData = new int[2][];
                barData[0] = new int[count];
                List<int> countList = new List<int>();
                for (int i = 0; i < count; i++)
                {
                    double min = lastMin;
                    double litteleMax = lastMin + _chartColumnConfig.AxesXStep;
                    barData[0][i] = (int)min;
                    int totalCount = jumpPoints.Where(p => p.DiffSample >= min && p.DiffSample < litteleMax).ToList().Count();
                    countList.Add(totalCount);
                    lastMin = litteleMax;
                }
                barData[1] = countList.ToArray();

                chart2.Titles.Clear();
                chart2.Series.Clear();
                Title tile = new Title(_chartColumnConfig.ChartTitle);
                tile.Font = _chartColumnConfig.ChartTitleFont;
                chart2.AntiAliasing = AntiAliasingStyles.Graphics;
                chart2.Titles.Add(tile);
                Series s1 = new Series();
                s1.ChartType = SeriesChartType.RangeColumn;
                s1.IsVisibleInLegend = false;
                chart2.BorderlineColor = Color.Black;
                chart2.BorderSkin = new BorderSkin();
                chart2.BorderSkin.BorderWidth = 2;
                chart2.ChartAreas[0].AxisX.Minimum = _chartColumnConfig.AxesXMin;
                chart2.ChartAreas[0].AxisX.Interval = _chartColumnConfig.AxesXStep;
                chart2.ChartAreas[0].AxisX.Title = _chartColumnConfig.AxesXTitle;
                chart2.ChartAreas[0].AxisX.TitleFont = _chartColumnConfig.AxesXFont;
                chart2.ChartAreas[0].AxisX.Maximum = _chartColumnConfig.AxesXMax;

                chart2.ChartAreas[0].AxisY.Interval = _chartColumnConfig.AxesYStep;
                chart2.ChartAreas[0].AxisY.Minimum = _chartColumnConfig.AxesYMin;
                chart2.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
                chart2.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
                chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
                chart2.ChartAreas[0].AxisY.Title = _chartColumnConfig.AxesYTitle;
                chart2.ChartAreas[0].AxisY.MinorTickMark.Interval = 1;
                chart2.ChartAreas[0].AxisY.TitleFont = _chartColumnConfig.AxesYFont;
                //chart2.ChartAreas[0].BorderWidth = 3;
                //chart2.ChartAreas[0].AxisX.IsLabelAutoFit = false;
                //chart2.ChartAreas[0].AxisX.IsInterlaced = false;
                //chart2.ChartAreas[0].AxisX.IntervalOffset = 0;
                //chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                lastMin = _chartColumnConfig.AxesXMin;
                double currentMin = 0;
                for (int i = 0; i < barData[0].Length; i++)
                {
                    s1.Points.AddXY(barData[0][i], barData[1][i]);
                    currentMin = lastMin + _chartColumnConfig.AxesXStep;
                    s1.Points[i].AxisLabel = lastMin + "-" + currentMin;
                    lastMin = currentMin;

                }


                s1.MarkerStyle = new MarkerStyle();
                s1.MarkerSize = 3;
                s1.MarkerColor = Color.Blue;
                chart2.Series.Add(s1);
                chart2.SaveImage(Application.StartupPath + "\\柱状图.jpg", ChartImageFormat.Jpeg);
                return true;
            }
            catch (Exception)
            {
                chart2.Titles.Clear();
                chart2.Series.Clear();
                return false;
            }
        }

        /// <summary>
        /// 跳变统计图
        /// </summary>
        /// <returns></returns>
        private bool CreateJumpChart()
        {
            try
            {
                int[] dataX = jumpPoints.Select(p => (int)p.CurrentMileage).ToList().Distinct().ToArray();
                double[] dataY = jumpPoints.Select(p => p.DiffSample).ToArray();
                chart3.Titles.Clear();
                chart3.Series.Clear();
                Title tile = new Title(_chartJumpConfig.ChartTitle);
                tile.Font = _chartJumpConfig.ChartTitleFont;
                chart3.AntiAliasing = AntiAliasingStyles.Graphics;
                chart3.Titles.Add(tile);
                Series s1 = new Series();
                s1.ChartType = SeriesChartType.RangeColumn;
                s1.IsVisibleInLegend = false;
                chart3.BorderlineColor = Color.Black;
                chart3.BorderSkin = new BorderSkin();
                chart3.BorderSkin.BorderWidth = 2;

                chart3.ChartAreas[0].AxisX.Minimum = _chartJumpConfig.AxesXMin;
                chart3.ChartAreas[0].AxisX.Interval = _chartJumpConfig.AxesXStep;
                chart3.ChartAreas[0].AxisX.Title = _chartJumpConfig.AxesXTitle;
                chart3.ChartAreas[0].AxisX.TitleFont = _chartJumpConfig.AxesXFont;

                chart3.ChartAreas[0].AxisY.Interval = _chartJumpConfig.AxesYStep;
                chart3.ChartAreas[0].AxisY.Minimum = _chartJumpConfig.AxesYMin;
                chart3.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
                chart3.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;

                chart3.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
                chart3.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
                chart3.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                chart3.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
                chart3.ChartAreas[0].AxisY.Title = _chartJumpConfig.AxesYTitle;
                chart3.ChartAreas[0].AxisY.TitleFont = _chartJumpConfig.AxesYFont;

                for (int i = 0; i < dataX.Length; i++)
                {
                    s1.Points.AddXY(dataX[i], dataY[i]);
                    //s1.Points[i].AxisLabel = dataX[i].ToString();
                }

                s1.MarkerStyle = new MarkerStyle();
                s1.MarkerSize = 3;
                s1.MarkerColor = Color.Blue;
                chart3.Series.Add(s1);
                chart3.SaveImage(Application.StartupPath + "\\柱状图.jpg", ChartImageFormat.Jpeg);
                return true;
            }
            catch (Exception)
            {
                chart3.Titles.Clear();
                chart3.Series.Clear();
                return false;
            }
        }

        private void btnChart1_Click(object sender, EventArgs e)
        {
            ChartConfigForm form = new ChartConfigForm(_chartScatterConfig);
            form.ShowDialog();
            if (form.Tag != null)
            {
                _chartScatterConfig = form.Tag as ChartConfig;
                CreateScatterChart();
            }
        }

        private void btnChart2_Click(object sender, EventArgs e)
        {
            ChartConfigForm form = new ChartConfigForm(_chartColumnConfig);
            form.ShowDialog();
            if (form.Tag != null)
            {
                _chartColumnConfig = form.Tag as ChartConfig;
                CreateColumnChart();
            }
        }

        private void btnChart3_Click(object sender, EventArgs e)
        {
            ChartConfigForm form = new ChartConfigForm(_chartJumpConfig);
            form.ShowDialog();
            if (form.Tag != null)
            {
                _chartJumpConfig = form.Tag as ChartConfig;
                CreateJumpChart();
            }
        }

        private void txtMaxForward_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("跳变结果中最大的Sample值", txtMaxForward);
        }

        private void txtMaxNegative_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("跳变结果中最小的Sample值", txtMaxNegative);
        }

        private void txtAverage_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("所有跳变点的采样差之和除以线路总长度(公里)", txtAverage);
        }

        private void txtAbsoluteAverage_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("所有跳变点的采样差的绝对值之和除以跳变总个数", txtAbsoluteAverage);
        }

        private void txtAll_MouseLeave(object sender,EventArgs e)
        {
            TextBox txt = sender as TextBox;
            toolTip1.Hide(txt);
        }

        private void dgvResult_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Delete)
            {
                if (dgvResult.SelectedRows != null && dgvResult.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("确定要删除这一行吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        string tableName = dgvResult.SelectedRows[0].Cells[3].Value.ToString();
                        _totalFileDal.Delete(tableName);
                        BindResultData();
                    }
                }
                else
                {
                    MessageBox.Show("请先选择一条数据！");
                }
            }
        }

        private void btnBro_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                PathTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PathTextBox.Text.Trim()))
            {
                MessageBox.Show("请先选择导出路径");
                return;
            }

            if (jumpPoints.Count <= 0)
            {
                MessageBox.Show("没有可导出的数据");
                return;
            }

            String excelPath = PathTextBox.Text.Trim();
            String excelName = "JumpPiont.csv";
            excelPath = Path.Combine(excelPath, excelName);

            StreamWriter sw = new StreamWriter(excelPath, false, Encoding.Default);

            StringBuilder sbtmp = new StringBuilder();

            sbtmp.Append("序号,");
            sbtmp.Append("当前公里(Km),");
            sbtmp.Append("当前采样（Smaple）,");
            sbtmp.Append("前一公里（Km）,");
            sbtmp.Append("前一采样（Smaple）,");
            sbtmp.Append("采样差（Smaple差）,");
            sbtmp.Append("公里差（m）");

            sw.WriteLine(sbtmp.ToString());

            for (int i = 0; i < jumpPoints.Count; i++)
            {
                sw.Write(i + 1);
                sw.Write(",");
                sw.Write(jumpPoints[i].CurrentMileage);
                sw.Write(",");
                sw.Write(jumpPoints[i].CurrentSample);
                sw.Write(",");
                sw.Write(jumpPoints[i].LastMileage);
                sw.Write(",");
                sw.Write(jumpPoints[i].LastSample);
                sw.Write(",");
                sw.Write(jumpPoints[i].DiffSample);
                sw.Write(",");
                sw.Write(jumpPoints[i].DiffMileage);
                sw.Write("\n");
            }

            sw.Close();

            MessageBox.Show("导出成功");

            //打开指定文件目录
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + excelPath;
            System.Diagnostics.Process.Start(psi);
            
        }

        /// <summary>
        /// 用户单击DataGridView时的事件处理方法。
        /// </summary>
        private void dgvData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                if (sender is DataGridView)
                {
                    DataGridView DgvGrid = (DataGridView)sender;
                    if (DgvGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        string objectId = DgvGrid["btnDelete", e.RowIndex].Value.ToString();
                        if (objectId == "删除")
                        {
                            string ID = DgvGrid.SelectedRows[0].Cells[0].Value.ToString();
                            //删除选中行
                            string whereStr = " where ID=" + ID;

                            _jumpDal.DeleteOne(tableName, whereStr);

                            //重新绑定数据
                            calcDgvResult();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            
        }


    }
}

namespace MileageCheckTools
{
    partial class ResultViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.cluLineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cluTrainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cluGeoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cluResultName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cluTotalLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAbsoluteAverage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaxNegative = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaxForward = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab = new System.Windows.Forms.Label();
            this.btnBro = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnChart1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnChart2 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnChart3 = new System.Windows.Forms.Button();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentSample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastSample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiffSample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiffMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToOrderColumns = true;
            this.dgvResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cluLineName,
            this.cluTrainName,
            this.cluGeoName,
            this.cluResultName,
            this.cluTotalLength});
            this.dgvResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvResult.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvResult.Location = new System.Drawing.Point(10, 13);
            this.dgvResult.MultiSelect = false;
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvResult.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResult.RowTemplate.Height = 23;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(625, 199);
            this.dgvResult.TabIndex = 3;
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            this.dgvResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvResult_KeyDown);
            // 
            // cluLineName
            // 
            this.cluLineName.DataPropertyName = "LineName";
            this.cluLineName.HeaderText = "线路名";
            this.cluLineName.Name = "cluLineName";
            this.cluLineName.ReadOnly = true;
            this.cluLineName.Width = 120;
            // 
            // cluTrainName
            // 
            this.cluTrainName.DataPropertyName = "TrainCode";
            this.cluTrainName.HeaderText = "轨检车型号";
            this.cluTrainName.Name = "cluTrainName";
            this.cluTrainName.ReadOnly = true;
            this.cluTrainName.Width = 120;
            // 
            // cluGeoName
            // 
            this.cluGeoName.DataPropertyName = "GeoFileName";
            this.cluGeoName.HeaderText = "Geo文件名";
            this.cluGeoName.Name = "cluGeoName";
            this.cluGeoName.ReadOnly = true;
            this.cluGeoName.Width = 250;
            // 
            // cluResultName
            // 
            this.cluResultName.DataPropertyName = "ResultTableName";
            this.cluResultName.HeaderText = "计算结果表名";
            this.cluResultName.Name = "cluResultName";
            this.cluResultName.ReadOnly = true;
            this.cluResultName.Width = 120;
            // 
            // cluTotalLength
            // 
            this.cluTotalLength.DataPropertyName = "TotalLength";
            this.cluTotalLength.HeaderText = "总里程";
            this.cluTotalLength.Name = "cluTotalLength";
            this.cluTotalLength.ReadOnly = true;
            this.cluTotalLength.Visible = false;
            // 
            // txtAbsoluteAverage
            // 
            this.txtAbsoluteAverage.Location = new System.Drawing.Point(107, 151);
            this.txtAbsoluteAverage.Name = "txtAbsoluteAverage";
            this.txtAbsoluteAverage.ReadOnly = true;
            this.txtAbsoluteAverage.Size = new System.Drawing.Size(100, 21);
            this.txtAbsoluteAverage.TabIndex = 7;
            this.txtAbsoluteAverage.MouseEnter += new System.EventHandler(this.txtAbsoluteAverage_MouseEnter);
            this.txtAbsoluteAverage.MouseLeave += new System.EventHandler(this.txtAll_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "跳变平均绝对值：";
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(107, 101);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(100, 21);
            this.txtAverage.TabIndex = 5;
            this.txtAverage.MouseEnter += new System.EventHandler(this.txtAverage_MouseEnter);
            this.txtAverage.MouseLeave += new System.EventHandler(this.txtAll_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "跳变平均值：";
            // 
            // txtMaxNegative
            // 
            this.txtMaxNegative.Location = new System.Drawing.Point(107, 59);
            this.txtMaxNegative.Name = "txtMaxNegative";
            this.txtMaxNegative.ReadOnly = true;
            this.txtMaxNegative.Size = new System.Drawing.Size(100, 21);
            this.txtMaxNegative.TabIndex = 3;
            this.txtMaxNegative.MouseEnter += new System.EventHandler(this.txtMaxNegative_MouseEnter);
            this.txtMaxNegative.MouseLeave += new System.EventHandler(this.txtAll_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "最大负向跳变：";
            // 
            // txtMaxForward
            // 
            this.txtMaxForward.Location = new System.Drawing.Point(107, 16);
            this.txtMaxForward.Name = "txtMaxForward";
            this.txtMaxForward.ReadOnly = true;
            this.txtMaxForward.Size = new System.Drawing.Size(100, 21);
            this.txtMaxForward.TabIndex = 1;
            this.txtMaxForward.MouseEnter += new System.EventHandler(this.txtMaxForward_MouseEnter);
            this.txtMaxForward.MouseLeave += new System.EventHandler(this.txtAll_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "最大正向跳变：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 218);
            this.panel1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtAverage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAbsoluteAverage);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaxNegative);
            this.groupBox1.Controls.Add(this.txtMaxForward);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(644, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 199);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lab);
            this.panel2.Controls.Add(this.btnBro);
            this.panel2.Controls.Add(this.PathTextBox);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 218);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(872, 30);
            this.panel2.TabIndex = 18;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(12, 9);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(65, 12);
            this.lab.TabIndex = 21;
            this.lab.Text = "导出路径：";
            // 
            // btnBro
            // 
            this.btnBro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBro.Location = new System.Drawing.Point(670, 3);
            this.btnBro.Name = "btnBro";
            this.btnBro.Size = new System.Drawing.Size(75, 23);
            this.btnBro.TabIndex = 20;
            this.btnBro.Text = "浏览";
            this.btnBro.UseVisualStyleBackColor = true;
            this.btnBro.Click += new System.EventHandler(this.btnBro_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PathTextBox.Enabled = false;
            this.PathTextBox.Location = new System.Drawing.Point(76, 5);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(559, 21);
            this.PathTextBox.TabIndex = 19;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(776, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "导出CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 293);
            this.panel3.TabIndex = 21;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 293);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(864, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CurrentMileage,
            this.CurrentSample,
            this.LastMileage,
            this.LastSample,
            this.DiffSample,
            this.DiffMileage,
            this.btnDelete});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvData.Location = new System.Drawing.Point(3, 3);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(858, 261);
            this.dgvData.TabIndex = 3;
            this.dgvData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvData_CellMouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnChart1);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(864, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "跳变分布图";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnChart1
            // 
            this.btnChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChart1.Location = new System.Drawing.Point(772, 6);
            this.btnChart1.Name = "btnChart1";
            this.btnChart1.Size = new System.Drawing.Size(75, 23);
            this.btnChart1.TabIndex = 1;
            this.btnChart1.Text = "绘图选项";
            this.btnChart1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(858, 261);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnChart2);
            this.tabPage3.Controls.Add(this.chart2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(864, 267);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "跳变柱状图";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnChart2
            // 
            this.btnChart2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChart2.Location = new System.Drawing.Point(772, 3);
            this.btnChart2.Name = "btnChart2";
            this.btnChart2.Size = new System.Drawing.Size(75, 23);
            this.btnChart2.TabIndex = 2;
            this.btnChart2.Text = "绘图选项";
            this.btnChart2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(864, 267);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnChart3);
            this.tabPage4.Controls.Add(this.chart3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(864, 267);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "跳变统计";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnChart3
            // 
            this.btnChart3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChart3.Location = new System.Drawing.Point(772, 3);
            this.btnChart3.Name = "btnChart3";
            this.btnChart3.Size = new System.Drawing.Size(75, 23);
            this.btnChart3.TabIndex = 3;
            this.btnChart3.Text = "绘图选项";
            this.btnChart3.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(0, 0);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(864, 267);
            this.chart3.TabIndex = 0;
            this.chart3.Text = "chart3";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ID.DefaultCellStyle = dataGridViewCellStyle4;
            this.ID.HeaderText = "序号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // CurrentMileage
            // 
            this.CurrentMileage.DataPropertyName = "CurrentMileage";
            this.CurrentMileage.HeaderText = "当前公里(Km)";
            this.CurrentMileage.Name = "CurrentMileage";
            this.CurrentMileage.ReadOnly = true;
            this.CurrentMileage.Width = 110;
            // 
            // CurrentSample
            // 
            this.CurrentSample.DataPropertyName = "CurrentSample";
            this.CurrentSample.HeaderText = "当前采样(Smaple)";
            this.CurrentSample.Name = "CurrentSample";
            this.CurrentSample.ReadOnly = true;
            this.CurrentSample.Width = 130;
            // 
            // LastMileage
            // 
            this.LastMileage.DataPropertyName = "LastMileage";
            this.LastMileage.HeaderText = "前一公里(Km)";
            this.LastMileage.Name = "LastMileage";
            this.LastMileage.ReadOnly = true;
            this.LastMileage.Width = 110;
            // 
            // LastSample
            // 
            this.LastSample.DataPropertyName = "LastSample";
            this.LastSample.HeaderText = "前一采样(Sample)";
            this.LastSample.Name = "LastSample";
            this.LastSample.ReadOnly = true;
            this.LastSample.Width = 130;
            // 
            // DiffSample
            // 
            this.DiffSample.DataPropertyName = "DiffSample";
            this.DiffSample.HeaderText = "采样差(Smaple差)";
            this.DiffSample.Name = "DiffSample";
            this.DiffSample.ReadOnly = true;
            this.DiffSample.Width = 130;
            // 
            // DiffMileage
            // 
            this.DiffMileage.DataPropertyName = "DiffMileage";
            this.DiffMileage.HeaderText = "公里差(m)";
            this.DiffMileage.Name = "DiffMileage";
            this.DiffMileage.ReadOnly = true;
            this.DiffMileage.Width = 110;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "操作";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "删除";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 60;
            // 
            // ResultViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 541);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ResultViewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "结果视图";
            this.Load += new System.EventHandler(this.ResultViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.TextBox txtAbsoluteAverage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaxNegative;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaxForward;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cluLineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cluTrainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cluGeoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cluResultName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cluTotalLength;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBro;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnChart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnChart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnChart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentSample;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastSample;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiffSample;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiffMileage;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}
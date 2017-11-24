namespace MileageCheckTools
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectGEO = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentSample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastSample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiffSample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiffMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnViewResult = new System.Windows.Forms.Button();
            this.btnWriteData = new System.Windows.Forms.Button();
            this.numUDJumpValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadGeo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLineName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTrain = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDJumpValue)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Geo波形文件|*.geo";
            // 
            // btnSelectGEO
            // 
            this.btnSelectGEO.AutoSize = true;
            this.btnSelectGEO.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectGEO.Location = new System.Drawing.Point(10, 9);
            this.btnSelectGEO.Name = "btnSelectGEO";
            this.btnSelectGEO.Size = new System.Drawing.Size(102, 30);
            this.btnSelectGEO.TabIndex = 3;
            this.btnSelectGEO.Text = "选择Geo文件";
            this.btnSelectGEO.UseVisualStyleBackColor = true;
            this.btnSelectGEO.Click += new System.EventHandler(this.btnSelectGEO_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CurrentMileage,
            this.CurrentSample,
            this.LastMileage,
            this.LastSample,
            this.DiffSample,
            this.DiffMileage});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(872, 325);
            this.dataGridView1.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.CurrentMileage.Width = 120;
            // 
            // CurrentSample
            // 
            this.CurrentSample.DataPropertyName = "CurrentSample";
            this.CurrentSample.HeaderText = "当前采样(Smaple)";
            this.CurrentSample.Name = "CurrentSample";
            this.CurrentSample.ReadOnly = true;
            this.CurrentSample.Width = 140;
            // 
            // LastMileage
            // 
            this.LastMileage.DataPropertyName = "LastMileage";
            this.LastMileage.HeaderText = "前一公里(Km)";
            this.LastMileage.Name = "LastMileage";
            this.LastMileage.ReadOnly = true;
            this.LastMileage.Width = 120;
            // 
            // LastSample
            // 
            this.LastSample.DataPropertyName = "LastSample";
            this.LastSample.HeaderText = "前一采样(Sample)";
            this.LastSample.Name = "LastSample";
            this.LastSample.ReadOnly = true;
            this.LastSample.Width = 140;
            // 
            // DiffSample
            // 
            this.DiffSample.DataPropertyName = "DiffSample";
            this.DiffSample.HeaderText = "采样差(Smaple差)";
            this.DiffSample.Name = "DiffSample";
            this.DiffSample.ReadOnly = true;
            this.DiffSample.Width = 140;
            // 
            // DiffMileage
            // 
            this.DiffMileage.DataPropertyName = "DiffMileage";
            this.DiffMileage.HeaderText = "公里差(m)";
            this.DiffMileage.Name = "DiffMileage";
            this.DiffMileage.ReadOnly = true;
            this.DiffMileage.Width = 120;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // btnViewResult
            // 
            this.btnViewResult.AutoSize = true;
            this.btnViewResult.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnViewResult.Location = new System.Drawing.Point(804, 11);
            this.btnViewResult.Name = "btnViewResult";
            this.btnViewResult.Size = new System.Drawing.Size(56, 30);
            this.btnViewResult.TabIndex = 9;
            this.btnViewResult.Text = "查看";
            this.btnViewResult.UseVisualStyleBackColor = true;
            this.btnViewResult.Click += new System.EventHandler(this.btnViewResult_Click);
            // 
            // btnWriteData
            // 
            this.btnWriteData.AutoSize = true;
            this.btnWriteData.Enabled = false;
            this.btnWriteData.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteData.Location = new System.Drawing.Point(701, 11);
            this.btnWriteData.Name = "btnWriteData";
            this.btnWriteData.Size = new System.Drawing.Size(96, 30);
            this.btnWriteData.TabIndex = 8;
            this.btnWriteData.Text = "保存索引点";
            this.btnWriteData.UseVisualStyleBackColor = true;
            this.btnWriteData.Click += new System.EventHandler(this.btnWriteData_Click);
            // 
            // numUDJumpValue
            // 
            this.numUDJumpValue.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numUDJumpValue.Location = new System.Drawing.Point(215, 10);
            this.numUDJumpValue.Name = "numUDJumpValue";
            this.numUDJumpValue.Size = new System.Drawing.Size(59, 26);
            this.numUDJumpValue.TabIndex = 7;
            this.numUDJumpValue.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(114, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "跳变容许值(米)";
            // 
            // btnReadGeo
            // 
            this.btnReadGeo.AutoSize = true;
            this.btnReadGeo.Enabled = false;
            this.btnReadGeo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReadGeo.Location = new System.Drawing.Point(281, 10);
            this.btnReadGeo.Name = "btnReadGeo";
            this.btnReadGeo.Size = new System.Drawing.Size(95, 30);
            this.btnReadGeo.TabIndex = 5;
            this.btnReadGeo.Text = "计算跳变点";
            this.btnReadGeo.UseVisualStyleBackColor = true;
            this.btnReadGeo.Click += new System.EventHandler(this.btnReadGeo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(872, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel1.Text = "已加载的文件：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtLineName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxTrain);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnViewResult);
            this.panel1.Controls.Add(this.btnWriteData);
            this.panel1.Controls.Add(this.numUDJumpValue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReadGeo);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.btnSelectGEO);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 511);
            this.panel1.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(361, 166);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 23);
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 112);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(562, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 7;
            this.textBox3.MouseEnter += new System.EventHandler(this.textBox3_MouseEnter);
            this.textBox3.MouseLeave += new System.EventHandler(this.textBoxAll_MouseLeave);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "跳变平均值(绝对)：";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox4.Location = new System.Drawing.Point(252, 73);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 5;
            this.textBox4.MouseEnter += new System.EventHandler(this.textBox4_MouseEnter);
            this.textBox4.MouseLeave += new System.EventHandler(this.textBoxAll_MouseLeave);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "跳变平均值：";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(562, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.MouseEnter += new System.EventHandler(this.textBox2_MouseEnter);
            this.textBox2.MouseLeave += new System.EventHandler(this.textBoxAll_MouseLeave);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "最大负向跳变：";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(252, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBoxAll_MouseLeave);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "最大正向跳变：";
            // 
            // txtLineName
            // 
            this.txtLineName.Location = new System.Drawing.Point(608, 14);
            this.txtLineName.Name = "txtLineName";
            this.txtLineName.Size = new System.Drawing.Size(85, 21);
            this.txtLineName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(555, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "线路名";
            // 
            // cbxTrain
            // 
            this.cbxTrain.FormattingEnabled = true;
            this.cbxTrain.Location = new System.Drawing.Point(460, 14);
            this.cbxTrain.Name = "cbxTrain";
            this.cbxTrain.Size = new System.Drawing.Size(94, 20);
            this.cbxTrain.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(379, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "轨检车型号";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(872, 46);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 511);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据取值";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDJumpValue)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectGEO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btnViewResult;
        private System.Windows.Forms.Button btnWriteData;
        private System.Windows.Forms.NumericUpDown numUDJumpValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadGeo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ComboBox cbxTrain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLineName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentSample;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastSample;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiffSample;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiffMileage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


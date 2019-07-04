namespace 上位机
{
    partial class MainFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10D);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.But_Port_Link = new System.Windows.Forms.Button();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.Menu_Debug = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Sign_out = new System.Windows.Forms.ToolStripMenuItem();
            this.toolLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.But_LEDFlsh = new System.Windows.Forms.Button();
            this.Check_LED1 = new System.Windows.Forms.CheckBox();
            this.Check_LED0 = new System.Windows.Forms.CheckBox();
            this.But_BEEP_Delay = new System.Windows.Forms.Button();
            this.BEEP_ms = new System.Windows.Forms.TextBox();
            this.But_BEEP_OFF = new System.Windows.Forms.Button();
            this.But_BEEP_ON = new System.Windows.Forms.Button();
            this.But_LED1_OFF = new System.Windows.Forms.Button();
            this.But_LED1_ON = new System.Windows.Forms.Button();
            this.But_LED0_OFF = new System.Windows.Forms.Button();
            this.But_LED0_ON = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.But_PortWrite = new System.Windows.Forms.Button();
            this.Chart_ADC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Pic_LED0 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.But_Scan = new System.Windows.Forms.Button();
            this.Pic_BEEP = new System.Windows.Forms.PictureBox();
            this.Pic_LED1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.But_ADC = new System.Windows.Forms.Button();
            this.But_ADC_Change = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.But_Timer = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_ADC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_LED0)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_BEEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_LED1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(55, 20);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(119, 20);
            this.comboBox.TabIndex = 1;
            this.comboBox.Click += new System.EventHandler(this.ComboBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "串口：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1382400",
            "921600",
            "460800",
            "256000",
            "230400",
            "128000",
            "115200",
            "76800",
            "57600",
            "43000",
            "38400",
            "19200",
            "14400",
            "9600",
            "4800",
            "2400",
            "1200"});
            this.comboBox1.Location = new System.Drawing.Point(79, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "1.5"});
            this.comboBox2.Location = new System.Drawing.Point(79, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(95, 20);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.comboBox3.Location = new System.Drawing.Point(79, 101);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(95, 20);
            this.comboBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "停止位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "数据位：";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Enabled = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验",
            "校验位设为1",
            "校验位设为0"});
            this.comboBox4.Location = new System.Drawing.Point(79, 128);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(95, 20);
            this.comboBox4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "奇偶校验：";
            // 
            // But_Port_Link
            // 
            this.But_Port_Link.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.But_Port_Link.ImageKey = "OFF.png";
            this.But_Port_Link.ImageList = this.ImageList;
            this.But_Port_Link.Location = new System.Drawing.Point(79, 154);
            this.But_Port_Link.Name = "But_Port_Link";
            this.But_Port_Link.Size = new System.Drawing.Size(95, 32);
            this.But_Port_Link.TabIndex = 11;
            this.But_Port_Link.Text = "打开串口";
            this.But_Port_Link.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.But_Port_Link.UseVisualStyleBackColor = true;
            this.But_Port_Link.Click += new System.EventHandler(this.But_Port_Link_Click);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "ON.png");
            this.ImageList.Images.SetKeyName(1, "OFF.png");
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(700, 22);
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Debug,
            this.Menu_Sign_out});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // Menu_Debug
            // 
            this.Menu_Debug.Name = "Menu_Debug";
            this.Menu_Debug.Size = new System.Drawing.Size(148, 22);
            this.Menu_Debug.Text = "打开调试模式";
            this.Menu_Debug.Click += new System.EventHandler(this.Menu_Debug_Click);
            // 
            // Menu_Sign_out
            // 
            this.Menu_Sign_out.Name = "Menu_Sign_out";
            this.Menu_Sign_out.Size = new System.Drawing.Size(148, 22);
            this.Menu_Sign_out.Text = "登出";
            this.Menu_Sign_out.Click += new System.EventHandler(this.Menu_Sign_out_Click);
            // 
            // toolLabel
            // 
            this.toolLabel.AccessibleDescription = "GET_DATA";
            this.toolLabel.Name = "toolLabel";
            this.toolLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 2000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.But_LEDFlsh);
            this.groupBox1.Controls.Add(this.Check_LED1);
            this.groupBox1.Controls.Add(this.Check_LED0);
            this.groupBox1.Controls.Add(this.But_BEEP_Delay);
            this.groupBox1.Controls.Add(this.BEEP_ms);
            this.groupBox1.Controls.Add(this.But_BEEP_OFF);
            this.groupBox1.Controls.Add(this.But_BEEP_ON);
            this.groupBox1.Controls.Add(this.But_LED1_OFF);
            this.groupBox1.Controls.Add(this.But_LED1_ON);
            this.groupBox1.Controls.Add(this.But_LED0_OFF);
            this.groupBox1.Controls.Add(this.But_LED0_ON);
            this.groupBox1.Location = new System.Drawing.Point(198, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 191);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "状态控制";
            // 
            // But_LEDFlsh
            // 
            this.But_LEDFlsh.Location = new System.Drawing.Point(87, 106);
            this.But_LEDFlsh.Name = "But_LEDFlsh";
            this.But_LEDFlsh.Size = new System.Drawing.Size(75, 38);
            this.But_LEDFlsh.TabIndex = 10;
            this.But_LEDFlsh.Text = "开始闪烁";
            this.But_LEDFlsh.UseVisualStyleBackColor = true;
            this.But_LEDFlsh.Click += new System.EventHandler(this.But_LEDFlsh_Click);
            // 
            // Check_LED1
            // 
            this.Check_LED1.AutoSize = true;
            this.Check_LED1.Checked = true;
            this.Check_LED1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Check_LED1.Location = new System.Drawing.Point(6, 128);
            this.Check_LED1.Name = "Check_LED1";
            this.Check_LED1.Size = new System.Drawing.Size(48, 16);
            this.Check_LED1.TabIndex = 9;
            this.Check_LED1.Text = "LED1";
            this.Check_LED1.UseVisualStyleBackColor = true;
            // 
            // Check_LED0
            // 
            this.Check_LED0.AutoSize = true;
            this.Check_LED0.Checked = true;
            this.Check_LED0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Check_LED0.Location = new System.Drawing.Point(6, 106);
            this.Check_LED0.Name = "Check_LED0";
            this.Check_LED0.Size = new System.Drawing.Size(48, 16);
            this.Check_LED0.TabIndex = 8;
            this.Check_LED0.Text = "LED0";
            this.Check_LED0.UseVisualStyleBackColor = true;
            // 
            // But_BEEP_Delay
            // 
            this.But_BEEP_Delay.Location = new System.Drawing.Point(87, 150);
            this.But_BEEP_Delay.Name = "But_BEEP_Delay";
            this.But_BEEP_Delay.Size = new System.Drawing.Size(75, 23);
            this.But_BEEP_Delay.TabIndex = 7;
            this.But_BEEP_Delay.Text = "BEEP短鸣";
            this.But_BEEP_Delay.UseVisualStyleBackColor = true;
            this.But_BEEP_Delay.Click += new System.EventHandler(this.But_BEEP_Delay_Click);
            // 
            // BEEP_ms
            // 
            this.BEEP_ms.Location = new System.Drawing.Point(6, 150);
            this.BEEP_ms.Name = "BEEP_ms";
            this.BEEP_ms.Size = new System.Drawing.Size(75, 21);
            this.BEEP_ms.TabIndex = 6;
            this.BEEP_ms.Text = "2000";
            // 
            // But_BEEP_OFF
            // 
            this.But_BEEP_OFF.Location = new System.Drawing.Point(87, 73);
            this.But_BEEP_OFF.Name = "But_BEEP_OFF";
            this.But_BEEP_OFF.Size = new System.Drawing.Size(75, 23);
            this.But_BEEP_OFF.TabIndex = 5;
            this.But_BEEP_OFF.Text = "BEEP关";
            this.But_BEEP_OFF.UseVisualStyleBackColor = true;
            this.But_BEEP_OFF.Click += new System.EventHandler(this.But_BEEP_OFF_Click);
            // 
            // But_BEEP_ON
            // 
            this.But_BEEP_ON.Location = new System.Drawing.Point(6, 73);
            this.But_BEEP_ON.Name = "But_BEEP_ON";
            this.But_BEEP_ON.Size = new System.Drawing.Size(75, 23);
            this.But_BEEP_ON.TabIndex = 4;
            this.But_BEEP_ON.Text = "BEEP开";
            this.But_BEEP_ON.UseVisualStyleBackColor = true;
            this.But_BEEP_ON.Click += new System.EventHandler(this.But_BEEP_ON_Click);
            // 
            // But_LED1_OFF
            // 
            this.But_LED1_OFF.Location = new System.Drawing.Point(87, 44);
            this.But_LED1_OFF.Name = "But_LED1_OFF";
            this.But_LED1_OFF.Size = new System.Drawing.Size(75, 23);
            this.But_LED1_OFF.TabIndex = 3;
            this.But_LED1_OFF.Text = "LED1关";
            this.But_LED1_OFF.UseVisualStyleBackColor = true;
            this.But_LED1_OFF.Click += new System.EventHandler(this.But_LED1_OFF_Click);
            // 
            // But_LED1_ON
            // 
            this.But_LED1_ON.Location = new System.Drawing.Point(6, 44);
            this.But_LED1_ON.Name = "But_LED1_ON";
            this.But_LED1_ON.Size = new System.Drawing.Size(75, 23);
            this.But_LED1_ON.TabIndex = 2;
            this.But_LED1_ON.Text = "LED1开";
            this.But_LED1_ON.UseVisualStyleBackColor = true;
            this.But_LED1_ON.Click += new System.EventHandler(this.But_LED1_ON_Click);
            // 
            // But_LED0_OFF
            // 
            this.But_LED0_OFF.Location = new System.Drawing.Point(87, 15);
            this.But_LED0_OFF.Name = "But_LED0_OFF";
            this.But_LED0_OFF.Size = new System.Drawing.Size(75, 23);
            this.But_LED0_OFF.TabIndex = 1;
            this.But_LED0_OFF.Text = "LED0关";
            this.But_LED0_OFF.UseVisualStyleBackColor = true;
            this.But_LED0_OFF.Click += new System.EventHandler(this.But_LED0_OFF_Click);
            // 
            // But_LED0_ON
            // 
            this.But_LED0_ON.Location = new System.Drawing.Point(6, 15);
            this.But_LED0_ON.Name = "But_LED0_ON";
            this.But_LED0_ON.Size = new System.Drawing.Size(75, 23);
            this.But_LED0_ON.TabIndex = 0;
            this.But_LED0_ON.Text = "LED0开";
            this.But_LED0_ON.UseVisualStyleBackColor = true;
            this.But_LED0_ON.Click += new System.EventHandler(this.But_LED0_ON_Click);
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.Location = new System.Drawing.Point(12, 215);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(180, 183);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 404);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 21);
            this.textBox3.TabIndex = 15;
            // 
            // But_PortWrite
            // 
            this.But_PortWrite.Location = new System.Drawing.Point(128, 404);
            this.But_PortWrite.Name = "But_PortWrite";
            this.But_PortWrite.Size = new System.Drawing.Size(75, 23);
            this.But_PortWrite.TabIndex = 16;
            this.But_PortWrite.Text = "发送";
            this.But_PortWrite.UseVisualStyleBackColor = true;
            this.But_PortWrite.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Chart_ADC
            // 
            this.Chart_ADC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.Name = "ChartArea1";
            this.Chart_ADC.ChartAreas.Add(chartArea1);
            this.Chart_ADC.Location = new System.Drawing.Point(6, 20);
            this.Chart_ADC.Name = "Chart_ADC";
            this.Chart_ADC.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsXValueIndexed = true;
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            this.Chart_ADC.Series.Add(series1);
            this.Chart_ADC.Size = new System.Drawing.Size(300, 182);
            this.Chart_ADC.TabIndex = 17;
            // 
            // Pic_LED0
            // 
            this.Pic_LED0.Location = new System.Drawing.Point(6, 20);
            this.Pic_LED0.Name = "Pic_LED0";
            this.Pic_LED0.Size = new System.Drawing.Size(32, 32);
            this.Pic_LED0.TabIndex = 18;
            this.Pic_LED0.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.But_Scan);
            this.groupBox2.Controls.Add(this.Pic_BEEP);
            this.groupBox2.Controls.Add(this.Pic_LED1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Pic_LED0);
            this.groupBox2.Location = new System.Drawing.Point(204, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 143);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "状态";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(107, 21);
            this.textBox1.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "外部中断次数：";
            // 
            // But_Scan
            // 
            this.But_Scan.Location = new System.Drawing.Point(39, 114);
            this.But_Scan.Name = "But_Scan";
            this.But_Scan.Size = new System.Drawing.Size(75, 23);
            this.But_Scan.TabIndex = 24;
            this.But_Scan.Text = "咨询状态";
            this.But_Scan.UseVisualStyleBackColor = true;
            this.But_Scan.Click += new System.EventHandler(this.But_Scan_Click);
            // 
            // Pic_BEEP
            // 
            this.Pic_BEEP.Location = new System.Drawing.Point(82, 20);
            this.Pic_BEEP.Name = "Pic_BEEP";
            this.Pic_BEEP.Size = new System.Drawing.Size(32, 32);
            this.Pic_BEEP.TabIndex = 23;
            this.Pic_BEEP.TabStop = false;
            // 
            // Pic_LED1
            // 
            this.Pic_LED1.Location = new System.Drawing.Point(44, 20);
            this.Pic_LED1.Name = "Pic_LED1";
            this.Pic_LED1.Size = new System.Drawing.Size(32, 32);
            this.Pic_LED1.TabIndex = 22;
            this.Pic_LED1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "BEEP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "LED1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "LED0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.But_ADC);
            this.groupBox3.Controls.Add(this.But_ADC_Change);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.comboBox5);
            this.groupBox3.Controls.Add(this.Chart_ADC);
            this.groupBox3.Location = new System.Drawing.Point(377, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 294);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ADC";
            // 
            // But_ADC
            // 
            this.But_ADC.Location = new System.Drawing.Point(110, 266);
            this.But_ADC.Name = "But_ADC";
            this.But_ADC.Size = new System.Drawing.Size(75, 23);
            this.But_ADC.TabIndex = 23;
            this.But_ADC.Text = "采集ADC值";
            this.But_ADC.UseVisualStyleBackColor = true;
            this.But_ADC.Click += new System.EventHandler(this.But_ADC_Click);
            // 
            // But_ADC_Change
            // 
            this.But_ADC_Change.Enabled = false;
            this.But_ADC_Change.Location = new System.Drawing.Point(191, 266);
            this.But_ADC_Change.Name = "But_ADC_Change";
            this.But_ADC_Change.Size = new System.Drawing.Size(100, 23);
            this.But_ADC_Change.TabIndex = 22;
            this.But_ADC_Change.Text = "修改采样方式";
            this.But_ADC_Change.UseVisualStyleBackColor = true;
            this.But_ADC_Change.Click += new System.EventHandler(this.But_ADC_Change_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(120, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "采样次数：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "采样周期：";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(191, 239);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = "1";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Enabled = false;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "3",
            "15",
            "28",
            "56",
            "84",
            "112",
            "144",
            "480"});
            this.comboBox5.Location = new System.Drawing.Point(191, 213);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 20);
            this.comboBox5.TabIndex = 18;
            // 
            // But_Timer
            // 
            this.But_Timer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.But_Timer.ImageKey = "OFF.png";
            this.But_Timer.ImageList = this.ImageList;
            this.But_Timer.Location = new System.Drawing.Point(568, 358);
            this.But_Timer.Name = "But_Timer";
            this.But_Timer.Size = new System.Drawing.Size(120, 32);
            this.But_Timer.TabIndex = 23;
            this.But_Timer.Text = "开启实时更新";
            this.But_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.But_Timer.UseVisualStyleBackColor = true;
            this.But_Timer.Click += new System.EventHandler(this.But_Timer_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.comboBox);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.comboBox3);
            this.groupBox4.Controls.Add(this.But_Port_Link);
            this.groupBox4.Controls.Add(this.comboBox4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 197);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "串口连接";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(568, 331);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(97, 21);
            this.textBox5.TabIndex = 24;
            this.textBox5.Text = "2000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(671, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "ms";
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.But_Timer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.But_PortWrite);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip);
            this.Name = "MainFrom";
            this.Text = "主";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_ADC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_LED0)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_BEEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_LED1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button But_Port_Link;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Sign_out;
        private System.Windows.Forms.ToolStripMenuItem Menu_Debug;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button But_BEEP_OFF;
        private System.Windows.Forms.Button But_BEEP_ON;
        private System.Windows.Forms.Button But_LED1_OFF;
        private System.Windows.Forms.Button But_LED1_ON;
        private System.Windows.Forms.Button But_LED0_OFF;
        private System.Windows.Forms.Button But_LED0_ON;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Button But_BEEP_Delay;
        private System.Windows.Forms.TextBox BEEP_ms;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button But_PortWrite;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_ADC;
        private System.Windows.Forms.Button But_LEDFlsh;
        private System.Windows.Forms.CheckBox Check_LED1;
        private System.Windows.Forms.CheckBox Check_LED0;
        private System.Windows.Forms.PictureBox Pic_LED0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button But_Scan;
        private System.Windows.Forms.PictureBox Pic_BEEP;
        private System.Windows.Forms.PictureBox Pic_LED1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button But_ADC_Change;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripStatusLabel toolLabel;
        private System.Windows.Forms.Button But_Timer;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button But_ADC;
        private System.Windows.Forms.Label label12;
    }
}


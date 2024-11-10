namespace MultiAxisMotionControl0630
{
    partial class Form1
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
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MotorPosition_01 = new System.Windows.Forms.TextBox();
            this.MotorPosition_02 = new System.Windows.Forms.TextBox();
            this.MotorPosition_03 = new System.Windows.Forms.TextBox();
            this.MotorSpeed_01 = new System.Windows.Forms.TextBox();
            this.MotorSpeed_02 = new System.Windows.Forms.TextBox();
            this.MotorSpeed_03 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NewMotorPosition_01 = new System.Windows.Forms.TextBox();
            this.NewMotorSpeed_01 = new System.Windows.Forms.TextBox();
            this.NewMotorPosition_02 = new System.Windows.Forms.TextBox();
            this.NewMotorSpeed_02 = new System.Windows.Forms.TextBox();
            this.NewMotorPosition_03 = new System.Windows.Forms.TextBox();
            this.NewMotorSpeed_03 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.axleStateText01 = new System.Windows.Forms.TextBox();
            this.axleStateText02 = new System.Windows.Forms.TextBox();
            this.axleStateText03 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ErrorCode01 = new System.Windows.Forms.TextBox();
            this.ErrorCode02 = new System.Windows.Forms.TextBox();
            this.ErrorCode03 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ErrorData101 = new System.Windows.Forms.TextBox();
            this.ErrorData102 = new System.Windows.Forms.TextBox();
            this.ErrorData103 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ErrorData201 = new System.Windows.Forms.TextBox();
            this.ErrorData202 = new System.Windows.Forms.TextBox();
            this.ErrorData203 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ClearError_Axle01 = new System.Windows.Forms.Button();
            this.ClearError_Axle02 = new System.Windows.Forms.Button();
            this.ClearError_Axle03 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.PLCSysPatternLable = new System.Windows.Forms.Label();
            this.PLCSysStateLable = new System.Windows.Forms.Label();
            this.PLCErrorNumberLable = new System.Windows.Forms.Label();
            this.PLCClearError = new System.Windows.Forms.Button();
            this.ChangeSystemPattern = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(472, 23);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(100, 21);
            this.textBox13.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(400, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 21;
            this.label13.Text = "连接状态：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(686, 22);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "断开连接";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "连接并使能";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 23);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 21);
            this.textBox2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "端口：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 21);
            this.textBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "IP地址：";
            // 
            // MotorPosition_01
            // 
            this.MotorPosition_01.Location = new System.Drawing.Point(56, 103);
            this.MotorPosition_01.Name = "MotorPosition_01";
            this.MotorPosition_01.Size = new System.Drawing.Size(100, 21);
            this.MotorPosition_01.TabIndex = 23;
            // 
            // MotorPosition_02
            // 
            this.MotorPosition_02.Location = new System.Drawing.Point(56, 141);
            this.MotorPosition_02.Name = "MotorPosition_02";
            this.MotorPosition_02.Size = new System.Drawing.Size(100, 21);
            this.MotorPosition_02.TabIndex = 23;
            // 
            // MotorPosition_03
            // 
            this.MotorPosition_03.Location = new System.Drawing.Point(56, 180);
            this.MotorPosition_03.Name = "MotorPosition_03";
            this.MotorPosition_03.Size = new System.Drawing.Size(100, 21);
            this.MotorPosition_03.TabIndex = 23;
            // 
            // MotorSpeed_01
            // 
            this.MotorSpeed_01.Location = new System.Drawing.Point(184, 103);
            this.MotorSpeed_01.Name = "MotorSpeed_01";
            this.MotorSpeed_01.Size = new System.Drawing.Size(100, 21);
            this.MotorSpeed_01.TabIndex = 23;
            // 
            // MotorSpeed_02
            // 
            this.MotorSpeed_02.Location = new System.Drawing.Point(184, 141);
            this.MotorSpeed_02.Name = "MotorSpeed_02";
            this.MotorSpeed_02.Size = new System.Drawing.Size(100, 21);
            this.MotorSpeed_02.TabIndex = 23;
            // 
            // MotorSpeed_03
            // 
            this.MotorSpeed_03.Location = new System.Drawing.Point(184, 180);
            this.MotorSpeed_03.Name = "MotorSpeed_03";
            this.MotorSpeed_03.Size = new System.Drawing.Size(100, 21);
            this.MotorSpeed_03.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(696, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "write in";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "速度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "位置";
            // 
            // NewMotorPosition_01
            // 
            this.NewMotorPosition_01.Location = new System.Drawing.Point(443, 105);
            this.NewMotorPosition_01.Name = "NewMotorPosition_01";
            this.NewMotorPosition_01.Size = new System.Drawing.Size(100, 21);
            this.NewMotorPosition_01.TabIndex = 23;
            // 
            // NewMotorSpeed_01
            // 
            this.NewMotorSpeed_01.Location = new System.Drawing.Point(571, 105);
            this.NewMotorSpeed_01.Name = "NewMotorSpeed_01";
            this.NewMotorSpeed_01.Size = new System.Drawing.Size(100, 21);
            this.NewMotorSpeed_01.TabIndex = 23;
            this.NewMotorSpeed_01.Text = "500";
            // 
            // NewMotorPosition_02
            // 
            this.NewMotorPosition_02.Location = new System.Drawing.Point(443, 143);
            this.NewMotorPosition_02.Name = "NewMotorPosition_02";
            this.NewMotorPosition_02.Size = new System.Drawing.Size(100, 21);
            this.NewMotorPosition_02.TabIndex = 23;
            // 
            // NewMotorSpeed_02
            // 
            this.NewMotorSpeed_02.Location = new System.Drawing.Point(571, 143);
            this.NewMotorSpeed_02.Name = "NewMotorSpeed_02";
            this.NewMotorSpeed_02.Size = new System.Drawing.Size(100, 21);
            this.NewMotorSpeed_02.TabIndex = 23;
            this.NewMotorSpeed_02.Text = "500";
            // 
            // NewMotorPosition_03
            // 
            this.NewMotorPosition_03.Location = new System.Drawing.Point(443, 182);
            this.NewMotorPosition_03.Name = "NewMotorPosition_03";
            this.NewMotorPosition_03.Size = new System.Drawing.Size(100, 21);
            this.NewMotorPosition_03.TabIndex = 23;
            // 
            // NewMotorSpeed_03
            // 
            this.NewMotorSpeed_03.Location = new System.Drawing.Point(571, 182);
            this.NewMotorSpeed_03.Name = "NewMotorSpeed_03";
            this.NewMotorSpeed_03.Size = new System.Drawing.Size(100, 21);
            this.NewMotorSpeed_03.TabIndex = 23;
            this.NewMotorSpeed_03.Text = "500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "新速度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "新位置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "轴01";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "轴02";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "轴03";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(696, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "write in";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(696, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "write in";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button3_Click);
            // 
            // axleStateText01
            // 
            this.axleStateText01.Location = new System.Drawing.Point(318, 102);
            this.axleStateText01.Name = "axleStateText01";
            this.axleStateText01.Size = new System.Drawing.Size(100, 21);
            this.axleStateText01.TabIndex = 23;
            this.axleStateText01.Text = "正常";
            // 
            // axleStateText02
            // 
            this.axleStateText02.Location = new System.Drawing.Point(318, 140);
            this.axleStateText02.Name = "axleStateText02";
            this.axleStateText02.Size = new System.Drawing.Size(100, 21);
            this.axleStateText02.TabIndex = 23;
            this.axleStateText02.Text = "正常";
            // 
            // axleStateText03
            // 
            this.axleStateText03.Location = new System.Drawing.Point(318, 179);
            this.axleStateText03.Name = "axleStateText03";
            this.axleStateText03.Size = new System.Drawing.Size(100, 21);
            this.axleStateText03.TabIndex = 23;
            this.axleStateText03.Text = "正常";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "状态";
            // 
            // ErrorCode01
            // 
            this.ErrorCode01.Location = new System.Drawing.Point(56, 260);
            this.ErrorCode01.Name = "ErrorCode01";
            this.ErrorCode01.Size = new System.Drawing.Size(100, 21);
            this.ErrorCode01.TabIndex = 23;
            // 
            // ErrorCode02
            // 
            this.ErrorCode02.Location = new System.Drawing.Point(56, 298);
            this.ErrorCode02.Name = "ErrorCode02";
            this.ErrorCode02.Size = new System.Drawing.Size(100, 21);
            this.ErrorCode02.TabIndex = 23;
            // 
            // ErrorCode03
            // 
            this.ErrorCode03.Location = new System.Drawing.Point(56, 337);
            this.ErrorCode03.Name = "ErrorCode03";
            this.ErrorCode03.Size = new System.Drawing.Size(100, 21);
            this.ErrorCode03.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "错误代码";
            // 
            // ErrorData101
            // 
            this.ErrorData101.Location = new System.Drawing.Point(172, 259);
            this.ErrorData101.Name = "ErrorData101";
            this.ErrorData101.Size = new System.Drawing.Size(100, 21);
            this.ErrorData101.TabIndex = 23;
            // 
            // ErrorData102
            // 
            this.ErrorData102.Location = new System.Drawing.Point(172, 297);
            this.ErrorData102.Name = "ErrorData102";
            this.ErrorData102.Size = new System.Drawing.Size(100, 21);
            this.ErrorData102.TabIndex = 23;
            // 
            // ErrorData103
            // 
            this.ErrorData103.Location = new System.Drawing.Point(172, 336);
            this.ErrorData103.Name = "ErrorData103";
            this.ErrorData103.Size = new System.Drawing.Size(100, 21);
            this.ErrorData103.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(182, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "错误详细信息1";
            // 
            // ErrorData201
            // 
            this.ErrorData201.Location = new System.Drawing.Point(289, 259);
            this.ErrorData201.Name = "ErrorData201";
            this.ErrorData201.Size = new System.Drawing.Size(100, 21);
            this.ErrorData201.TabIndex = 23;
            // 
            // ErrorData202
            // 
            this.ErrorData202.Location = new System.Drawing.Point(289, 297);
            this.ErrorData202.Name = "ErrorData202";
            this.ErrorData202.Size = new System.Drawing.Size(100, 21);
            this.ErrorData202.TabIndex = 23;
            // 
            // ErrorData203
            // 
            this.ErrorData203.Location = new System.Drawing.Point(289, 336);
            this.ErrorData203.Name = "ErrorData203";
            this.ErrorData203.Size = new System.Drawing.Size(100, 21);
            this.ErrorData203.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(299, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 25;
            this.label14.Text = "错误详细信息2";
            // 
            // ClearError_Axle01
            // 
            this.ClearError_Axle01.Location = new System.Drawing.Point(414, 256);
            this.ClearError_Axle01.Name = "ClearError_Axle01";
            this.ClearError_Axle01.Size = new System.Drawing.Size(167, 23);
            this.ClearError_Axle01.TabIndex = 26;
            this.ClearError_Axle01.Text = "清除错误并获得错误代码";
            this.ClearError_Axle01.UseVisualStyleBackColor = true;
            this.ClearError_Axle01.Click += new System.EventHandler(this.ClearError_Axle01_Click);
            // 
            // ClearError_Axle02
            // 
            this.ClearError_Axle02.Location = new System.Drawing.Point(414, 295);
            this.ClearError_Axle02.Name = "ClearError_Axle02";
            this.ClearError_Axle02.Size = new System.Drawing.Size(167, 23);
            this.ClearError_Axle02.TabIndex = 26;
            this.ClearError_Axle02.Text = "清除错误并获得错误代码";
            this.ClearError_Axle02.UseVisualStyleBackColor = true;
            this.ClearError_Axle02.Click += new System.EventHandler(this.ClearError_Axle01_Click);
            // 
            // ClearError_Axle03
            // 
            this.ClearError_Axle03.Location = new System.Drawing.Point(414, 336);
            this.ClearError_Axle03.Name = "ClearError_Axle03";
            this.ClearError_Axle03.Size = new System.Drawing.Size(167, 23);
            this.ClearError_Axle03.TabIndex = 26;
            this.ClearError_Axle03.Text = "清除错误并获得错误代码";
            this.ClearError_Axle03.UseVisualStyleBackColor = true;
            this.ClearError_Axle03.Click += new System.EventHandler(this.ClearError_Axle01_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 25;
            this.label15.Text = "轴01";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 299);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 25;
            this.label16.Text = "轴02";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 341);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 25;
            this.label17.Text = "轴03";
            // 
            // PLCSysPatternLable
            // 
            this.PLCSysPatternLable.AutoSize = true;
            this.PLCSysPatternLable.Location = new System.Drawing.Point(6, 39);
            this.PLCSysPatternLable.Name = "PLCSysPatternLable";
            this.PLCSysPatternLable.Size = new System.Drawing.Size(83, 12);
            this.PLCSysPatternLable.TabIndex = 25;
            this.PLCSysPatternLable.Text = "PLC系统模式：";
            // 
            // PLCSysStateLable
            // 
            this.PLCSysStateLable.AutoSize = true;
            this.PLCSysStateLable.Location = new System.Drawing.Point(140, 39);
            this.PLCSysStateLable.Name = "PLCSysStateLable";
            this.PLCSysStateLable.Size = new System.Drawing.Size(83, 12);
            this.PLCSysStateLable.TabIndex = 25;
            this.PLCSysStateLable.Text = "PLC系统状态：";
            // 
            // PLCErrorNumberLable
            // 
            this.PLCErrorNumberLable.AutoSize = true;
            this.PLCErrorNumberLable.Location = new System.Drawing.Point(282, 39);
            this.PLCErrorNumberLable.Name = "PLCErrorNumberLable";
            this.PLCErrorNumberLable.Size = new System.Drawing.Size(65, 12);
            this.PLCErrorNumberLable.TabIndex = 25;
            this.PLCErrorNumberLable.Text = "错误编号：";
            // 
            // PLCClearError
            // 
            this.PLCClearError.Location = new System.Drawing.Point(504, 34);
            this.PLCClearError.Name = "PLCClearError";
            this.PLCClearError.Size = new System.Drawing.Size(62, 23);
            this.PLCClearError.TabIndex = 24;
            this.PLCClearError.Text = "清除错误";
            this.PLCClearError.UseVisualStyleBackColor = true;
            this.PLCClearError.Click += new System.EventHandler(this.PLCClearError_Click);
            // 
            // ChangeSystemPattern
            // 
            this.ChangeSystemPattern.Location = new System.Drawing.Point(398, 34);
            this.ChangeSystemPattern.Name = "ChangeSystemPattern";
            this.ChangeSystemPattern.Size = new System.Drawing.Size(90, 23);
            this.ChangeSystemPattern.TabIndex = 24;
            this.ChangeSystemPattern.Text = "更改系统模式";
            this.ChangeSystemPattern.UseVisualStyleBackColor = true;
            this.ChangeSystemPattern.Click += new System.EventHandler(this.ChangeSystemPattern_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PLCSysPatternLable);
            this.groupBox1.Controls.Add(this.PLCClearError);
            this.groupBox1.Controls.Add(this.ChangeSystemPattern);
            this.groupBox1.Controls.Add(this.PLCSysStateLable);
            this.groupBox1.Controls.Add(this.PLCErrorNumberLable);
            this.groupBox1.Location = new System.Drawing.Point(12, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 76);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClearError_Axle03);
            this.Controls.Add(this.ClearError_Axle02);
            this.Controls.Add(this.ClearError_Axle01);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.NewMotorSpeed_03);
            this.Controls.Add(this.ErrorData203);
            this.Controls.Add(this.ErrorData103);
            this.Controls.Add(this.ErrorCode03);
            this.Controls.Add(this.axleStateText03);
            this.Controls.Add(this.MotorSpeed_03);
            this.Controls.Add(this.NewMotorPosition_03);
            this.Controls.Add(this.MotorPosition_03);
            this.Controls.Add(this.NewMotorSpeed_02);
            this.Controls.Add(this.ErrorData202);
            this.Controls.Add(this.ErrorData102);
            this.Controls.Add(this.ErrorCode02);
            this.Controls.Add(this.axleStateText02);
            this.Controls.Add(this.MotorSpeed_02);
            this.Controls.Add(this.NewMotorPosition_02);
            this.Controls.Add(this.MotorPosition_02);
            this.Controls.Add(this.NewMotorSpeed_01);
            this.Controls.Add(this.ErrorData201);
            this.Controls.Add(this.ErrorData101);
            this.Controls.Add(this.ErrorCode01);
            this.Controls.Add(this.axleStateText01);
            this.Controls.Add(this.MotorSpeed_01);
            this.Controls.Add(this.NewMotorPosition_01);
            this.Controls.Add(this.MotorPosition_01);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "上位链路通讯测试";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MotorPosition_01;
        private System.Windows.Forms.TextBox MotorPosition_02;
        private System.Windows.Forms.TextBox MotorPosition_03;
        private System.Windows.Forms.TextBox MotorSpeed_01;
        private System.Windows.Forms.TextBox MotorSpeed_02;
        private System.Windows.Forms.TextBox MotorSpeed_03;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewMotorPosition_01;
        private System.Windows.Forms.TextBox NewMotorSpeed_01;
        private System.Windows.Forms.TextBox NewMotorPosition_02;
        private System.Windows.Forms.TextBox NewMotorSpeed_02;
        private System.Windows.Forms.TextBox NewMotorPosition_03;
        private System.Windows.Forms.TextBox NewMotorSpeed_03;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox axleStateText01;
        private System.Windows.Forms.TextBox axleStateText02;
        private System.Windows.Forms.TextBox axleStateText03;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ErrorCode01;
        private System.Windows.Forms.TextBox ErrorCode02;
        private System.Windows.Forms.TextBox ErrorCode03;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ErrorData101;
        private System.Windows.Forms.TextBox ErrorData102;
        private System.Windows.Forms.TextBox ErrorData103;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ErrorData201;
        private System.Windows.Forms.TextBox ErrorData202;
        private System.Windows.Forms.TextBox ErrorData203;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ClearError_Axle01;
        private System.Windows.Forms.Button ClearError_Axle02;
        private System.Windows.Forms.Button ClearError_Axle03;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label PLCSysPatternLable;
        private System.Windows.Forms.Label PLCSysStateLable;
        private System.Windows.Forms.Label PLCErrorNumberLable;
        private System.Windows.Forms.Button PLCClearError;
        private System.Windows.Forms.Button ChangeSystemPattern;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
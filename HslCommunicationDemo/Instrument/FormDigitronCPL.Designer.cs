﻿namespace HslCommunicationDemo
{
    partial class FormDigitronCPL
	{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.textBox_station = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.textBox18 = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.textBox19 = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.userControlHead1 = new HslCommunicationDemo.DemoControl.UserControlHead();
			this.userControlReadWriteDevice1 = new HslCommunicationDemo.DemoControl.UserControlReadWriteDevice();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.comboBox3);
			this.panel1.Controls.Add(this.textBox_station);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label26);
			this.panel1.Controls.Add(this.textBox18);
			this.panel1.Controls.Add(this.label27);
			this.panel1.Controls.Add(this.textBox19);
			this.panel1.Controls.Add(this.label28);
			this.panel1.Controls.Add(this.label29);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label22);
			this.panel1.Controls.Add(this.label21);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(3, 35);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(997, 63);
			this.panel1.TabIndex = 0;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(57, 3);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(67, 25);
			this.comboBox3.TabIndex = 41;
			// 
			// textBox_station
			// 
			this.textBox_station.Location = new System.Drawing.Point(59, 33);
			this.textBox_station.Name = "textBox_station";
			this.textBox_station.Size = new System.Drawing.Size(31, 23);
			this.textBox_station.TabIndex = 40;
			this.textBox_station.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 17);
			this.label1.TabIndex = 39;
			this.label1.Text = "站号：";
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "无",
            "奇",
            "偶"});
			this.comboBox2.Location = new System.Drawing.Point(501, 3);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(60, 25);
			this.comboBox2.TabIndex = 38;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(436, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 17);
			this.label3.TabIndex = 37;
			this.label3.Text = "奇偶：";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(407, 4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(23, 23);
			this.textBox2.TabIndex = 36;
			this.textBox2.Text = "1";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(347, 7);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(56, 17);
			this.label26.TabIndex = 35;
			this.label26.Text = "停止位：";
			// 
			// textBox18
			// 
			this.textBox18.Location = new System.Drawing.Point(312, 4);
			this.textBox18.Name = "textBox18";
			this.textBox18.Size = new System.Drawing.Size(24, 23);
			this.textBox18.TabIndex = 34;
			this.textBox18.Text = "8";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(249, 7);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(56, 17);
			this.label27.TabIndex = 33;
			this.label27.Text = "数据位：";
			// 
			// textBox19
			// 
			this.textBox19.Location = new System.Drawing.Point(189, 4);
			this.textBox19.Name = "textBox19";
			this.textBox19.Size = new System.Drawing.Size(47, 23);
			this.textBox19.TabIndex = 32;
			this.textBox19.Text = "9600";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(129, 7);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(56, 17);
			this.label28.TabIndex = 31;
			this.label28.Text = "波特率：";
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(3, 7);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(59, 17);
			this.label29.TabIndex = 29;
			this.label29.Text = "Com口：";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(130, 31);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(95, 25);
			this.comboBox1.TabIndex = 14;
			this.comboBox1.Visible = false;
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(889, 7);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(84, 45);
			this.label22.TabIndex = 7;
			this.label22.Text = "100  200";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(831, 5);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(68, 17);
			this.label21.TabIndex = 6;
			this.label21.Text = "地址示例：";
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(710, 24);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(87, 28);
			this.button2.TabIndex = 5;
			this.button2.Text = "关闭串口";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(622, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 28);
			this.button1.TabIndex = 4;
			this.button1.Text = "打开串口";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.userControlReadWriteDevice1);
			this.panel2.Location = new System.Drawing.Point(3, 101);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(997, 541);
			this.panel2.TabIndex = 1;
			// 
			// userControlHead1
			// 
			this.userControlHead1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.userControlHead1.Dock = System.Windows.Forms.DockStyle.Top;
			this.userControlHead1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.userControlHead1.Location = new System.Drawing.Point(0, 0);
			this.userControlHead1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.userControlHead1.MinimumSize = new System.Drawing.Size(800, 32);
			this.userControlHead1.Name = "userControlHead1";
			this.userControlHead1.ProtocolInfo = "CPL";
			this.userControlHead1.Size = new System.Drawing.Size(1004, 32);
			this.userControlHead1.TabIndex = 2;
			this.userControlHead1.SaveConnectEvent += new System.EventHandler<System.EventArgs>(this.userControlHead1_SaveConnectEvent_1);
			// 
			// userControlReadWriteDevice1
			// 
			this.userControlReadWriteDevice1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userControlReadWriteDevice1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.userControlReadWriteDevice1.Location = new System.Drawing.Point(0, 0);
			this.userControlReadWriteDevice1.Name = "userControlReadWriteDevice1";
			this.userControlReadWriteDevice1.Size = new System.Drawing.Size(995, 539);
			this.userControlReadWriteDevice1.TabIndex = 0;
			// 
			// FormDigitronCPL
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1004, 645);
			this.Controls.Add(this.userControlHead1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormDigitronCPL";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "山武 CPL 数字指示调节器 访问Demo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSiemens_FormClosing);
			this.Load += new System.EventHandler(this.FormSiemens_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_station;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private DemoControl.UserControlHead userControlHead1;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label22;
		private DemoControl.UserControlReadWriteDevice userControlReadWriteDevice1;
	}
}
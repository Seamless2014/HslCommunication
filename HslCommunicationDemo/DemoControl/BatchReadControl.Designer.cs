﻿namespace HslCommunicationDemo.DemoControl
{
	partial class BatchReadControl
	{
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose( bool disposing )
		{
			if (disposing && (components != null))
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent( )
		{
			this.textBox_result = new System.Windows.Forms.TextBox();
			this.label_result = new System.Windows.Forms.Label();
			this.button_read = new System.Windows.Forms.Button();
			this.textBox_length = new System.Windows.Forms.TextBox();
			this.label_length = new System.Windows.Forms.Label();
			this.textBox_address = new System.Windows.Forms.TextBox();
			this.label_address = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_search = new System.Windows.Forms.TextBox();
			this.button_search = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioButton_ascii = new System.Windows.Forms.RadioButton();
			this.radioButton_hex = new System.Windows.Forms.RadioButton();
			this.button_read_random = new System.Windows.Forms.Button();
			this.button_read_word = new System.Windows.Forms.Button();
			this.label_index = new System.Windows.Forms.Label();
			this.label_tips = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox_result
			// 
			this.textBox_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_result.Location = new System.Drawing.Point(56, 54);
			this.textBox_result.Multiline = true;
			this.textBox_result.Name = "textBox_result";
			this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_result.Size = new System.Drawing.Size(683, 238);
			this.textBox_result.TabIndex = 33;
			// 
			// label_result
			// 
			this.label_result.AutoSize = true;
			this.label_result.Location = new System.Drawing.Point(3, 54);
			this.label_result.Name = "label_result";
			this.label_result.Size = new System.Drawing.Size(44, 17);
			this.label_result.TabIndex = 32;
			this.label_result.Text = "结果：";
			// 
			// button_read
			// 
			this.button_read.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_read.Location = new System.Drawing.Point(745, 1);
			this.button_read.Name = "button_read";
			this.button_read.Size = new System.Drawing.Size(97, 28);
			this.button_read.TabIndex = 31;
			this.button_read.Text = "批量读取";
			this.button_read.UseVisualStyleBackColor = true;
			// 
			// textBox_length
			// 
			this.textBox_length.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_length.Location = new System.Drawing.Point(524, 4);
			this.textBox_length.Name = "textBox_length";
			this.textBox_length.Size = new System.Drawing.Size(215, 23);
			this.textBox_length.TabIndex = 30;
			this.textBox_length.Text = "10";
			// 
			// label_length
			// 
			this.label_length.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_length.AutoSize = true;
			this.label_length.Location = new System.Drawing.Point(474, 7);
			this.label_length.Name = "label_length";
			this.label_length.Size = new System.Drawing.Size(44, 17);
			this.label_length.TabIndex = 29;
			this.label_length.Text = "长度：";
			// 
			// textBox_address
			// 
			this.textBox_address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_address.Location = new System.Drawing.Point(56, 4);
			this.textBox_address.Name = "textBox_address";
			this.textBox_address.Size = new System.Drawing.Size(412, 23);
			this.textBox_address.TabIndex = 28;
			// 
			// label_address
			// 
			this.label_address.AutoSize = true;
			this.label_address.Location = new System.Drawing.Point(1, 7);
			this.label_address.Name = "label_address";
			this.label_address.Size = new System.Drawing.Size(44, 17);
			this.label_address.TabIndex = 27;
			this.label_address.Text = "地址：";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(190, 298);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 17);
			this.label1.TabIndex = 34;
			this.label1.Text = "字节数：";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(312, 298);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 17);
			this.label2.TabIndex = 35;
			this.label2.Text = "耗时：";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(562, 298);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 17);
			this.label3.TabIndex = 36;
			this.label3.Text = "查找字符串：";
			// 
			// textBox_search
			// 
			this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_search.Location = new System.Drawing.Point(648, 294);
			this.textBox_search.Name = "textBox_search";
			this.textBox_search.Size = new System.Drawing.Size(91, 23);
			this.textBox_search.TabIndex = 37;
			this.textBox_search.Text = "10";
			// 
			// button_search
			// 
			this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_search.Location = new System.Drawing.Point(745, 290);
			this.button_search.Name = "button_search";
			this.button_search.Size = new System.Drawing.Size(97, 28);
			this.button_search.TabIndex = 38;
			this.button_search.Text = "查找";
			this.button_search.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.Controls.Add(this.radioButton_ascii);
			this.panel1.Controls.Add(this.radioButton_hex);
			this.panel1.Location = new System.Drawing.Point(56, 295);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(126, 24);
			this.panel1.TabIndex = 39;
			// 
			// radioButton_ascii
			// 
			this.radioButton_ascii.AutoSize = true;
			this.radioButton_ascii.Location = new System.Drawing.Point(59, 2);
			this.radioButton_ascii.Name = "radioButton_ascii";
			this.radioButton_ascii.Size = new System.Drawing.Size(57, 21);
			this.radioButton_ascii.TabIndex = 1;
			this.radioButton_ascii.Text = "ASCII";
			this.radioButton_ascii.UseVisualStyleBackColor = true;
			// 
			// radioButton_hex
			// 
			this.radioButton_hex.AutoSize = true;
			this.radioButton_hex.Checked = true;
			this.radioButton_hex.Location = new System.Drawing.Point(3, 2);
			this.radioButton_hex.Name = "radioButton_hex";
			this.radioButton_hex.Size = new System.Drawing.Size(50, 21);
			this.radioButton_hex.TabIndex = 0;
			this.radioButton_hex.TabStop = true;
			this.radioButton_hex.Text = "HEX";
			this.radioButton_hex.UseVisualStyleBackColor = true;
			// 
			// button_read_random
			// 
			this.button_read_random.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_read_random.Location = new System.Drawing.Point(745, 34);
			this.button_read_random.Name = "button_read_random";
			this.button_read_random.Size = new System.Drawing.Size(97, 28);
			this.button_read_random.TabIndex = 40;
			this.button_read_random.Text = "随机读取";
			this.button_read_random.UseVisualStyleBackColor = true;
			// 
			// button_read_word
			// 
			this.button_read_word.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_read_word.Location = new System.Drawing.Point(745, 68);
			this.button_read_word.Name = "button_read_word";
			this.button_read_word.Size = new System.Drawing.Size(97, 28);
			this.button_read_word.TabIndex = 41;
			this.button_read_word.Text = "随机字读取";
			this.button_read_word.UseVisualStyleBackColor = true;
			// 
			// label_index
			// 
			this.label_index.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label_index.AutoSize = true;
			this.label_index.ForeColor = System.Drawing.Color.Gray;
			this.label_index.Location = new System.Drawing.Point(763, 270);
			this.label_index.Name = "label_index";
			this.label_index.Size = new System.Drawing.Size(59, 17);
			this.label_index.TabIndex = 42;
			this.label_index.Text = "Index: -1";
			// 
			// label_tips
			// 
			this.label_tips.AutoSize = true;
			this.label_tips.ForeColor = System.Drawing.Color.Gray;
			this.label_tips.Location = new System.Drawing.Point(53, 32);
			this.label_tips.Name = "label_tips";
			this.label_tips.Size = new System.Drawing.Size(39, 17);
			this.label_tips.TabIndex = 43;
			this.label_tips.Text = "Tips: ";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(420, 298);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 17);
			this.label4.TabIndex = 44;
			this.label4.Text = "Select:";
			// 
			// BatchReadControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label_tips);
			this.Controls.Add(this.label_index);
			this.Controls.Add(this.button_read_word);
			this.Controls.Add(this.button_read_random);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button_search);
			this.Controls.Add(this.textBox_search);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_result);
			this.Controls.Add(this.label_result);
			this.Controls.Add(this.button_read);
			this.Controls.Add(this.textBox_length);
			this.Controls.Add(this.label_length);
			this.Controls.Add(this.textBox_address);
			this.Controls.Add(this.label_address);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Name = "BatchReadControl";
			this.Size = new System.Drawing.Size(845, 318);
			this.Load += new System.EventHandler(this.BatchReadControl_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_result;
		private System.Windows.Forms.Label label_result;
		private System.Windows.Forms.Button button_read;
		private System.Windows.Forms.TextBox textBox_length;
		private System.Windows.Forms.Label label_length;
		private System.Windows.Forms.TextBox textBox_address;
		private System.Windows.Forms.Label label_address;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_search;
		private System.Windows.Forms.Button button_search;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton radioButton_ascii;
		private System.Windows.Forms.RadioButton radioButton_hex;
		private System.Windows.Forms.Button button_read_random;
		private System.Windows.Forms.Button button_read_word;
		private System.Windows.Forms.Label label_index;
		private System.Windows.Forms.Label label_tips;
		private System.Windows.Forms.Label label4;
	}
}

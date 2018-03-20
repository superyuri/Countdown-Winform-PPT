using System;
namespace UppLink.Countdown
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Button();
            this.TimeBoxMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Countdown = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimeBoxSec = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.AlertBoxSec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AlertBoxMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CloseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PPTValue = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BackOnlyLastSecBox = new System.Windows.Forms.TextBox();
            this.BackOnlyLastCheck = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BackOnlyLastMinBox = new System.Windows.Forms.TextBox();
            this.BackSoundEnableCheck = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Enabled = false;
            this.Start.Location = new System.Drawing.Point(8, 43);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "开始计时";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(6, 14);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(75, 23);
            this.Display.TabIndex = 1;
            this.Display.Text = "显示界面";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // TimeBoxMin
            // 
            this.TimeBoxMin.Location = new System.Drawing.Point(10, 17);
            this.TimeBoxMin.Name = "TimeBoxMin";
            this.TimeBoxMin.Size = new System.Drawing.Size(23, 21);
            this.TimeBoxMin.TabIndex = 3;
            this.TimeBoxMin.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "秒";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(88, 124);
            this.listBox1.TabIndex = 8;
            // 
            // Countdown
            // 
            this.Countdown.AutoSize = true;
            this.Countdown.Checked = true;
            this.Countdown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Countdown.Location = new System.Drawing.Point(114, 21);
            this.Countdown.Name = "Countdown";
            this.Countdown.Size = new System.Drawing.Size(60, 16);
            this.Countdown.TabIndex = 9;
            this.Countdown.Text = "倒计时";
            this.Countdown.UseVisualStyleBackColor = true;
            this.Countdown.CheckedChanged += new System.EventHandler(this.Countdown_EnableCheckedChanged);
            this.Countdown.EnabledChanged += new System.EventHandler(this.Countdown_EnableCheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimeBoxSec);
            this.groupBox1.Controls.Add(this.Countdown);
            this.groupBox1.Controls.Add(this.TimeBoxMin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 48);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "计时";
            // 
            // TimeBoxSec
            // 
            this.TimeBoxSec.Location = new System.Drawing.Point(62, 17);
            this.TimeBoxSec.Name = "TimeBoxSec";
            this.TimeBoxSec.Size = new System.Drawing.Size(23, 21);
            this.TimeBoxSec.TabIndex = 10;
            this.TimeBoxSec.Text = "10";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Remove);
            this.groupBox2.Controls.Add(this.Add);
            this.groupBox2.Controls.Add(this.AlertBoxSec);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.AlertBoxMin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 177);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "警告";
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(114, 44);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(58, 23);
            this.Remove.TabIndex = 16;
            this.Remove.Text = "移除";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(114, 15);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(58, 23);
            this.Add.TabIndex = 15;
            this.Add.Text = "添加";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AlertBoxSec
            // 
            this.AlertBoxSec.Location = new System.Drawing.Point(62, 15);
            this.AlertBoxSec.Name = "AlertBoxSec";
            this.AlertBoxSec.Size = new System.Drawing.Size(23, 21);
            this.AlertBoxSec.TabIndex = 14;
            this.AlertBoxSec.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "分";
            // 
            // AlertBoxMin
            // 
            this.AlertBoxMin.Location = new System.Drawing.Point(10, 15);
            this.AlertBoxMin.Name = "AlertBoxMin";
            this.AlertBoxMin.Size = new System.Drawing.Size(23, 21);
            this.AlertBoxMin.TabIndex = 11;
            this.AlertBoxMin.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "秒";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CloseButton
            // 
            this.CloseButton.Enabled = false;
            this.CloseButton.Location = new System.Drawing.Point(8, 72);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "关闭界面";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "计时：";
            // 
            // PPTValue
            // 
            this.PPTValue.AutoSize = true;
            this.PPTValue.Location = new System.Drawing.Point(6, 123);
            this.PPTValue.Name = "PPTValue";
            this.PPTValue.Size = new System.Drawing.Size(0, 12);
            this.PPTValue.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Start);
            this.groupBox3.Controls.Add(this.PPTValue);
            this.groupBox3.Controls.Add(this.Display);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.CloseButton);
            this.groupBox3.Location = new System.Drawing.Point(197, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(86, 145);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "控制";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(23, 346);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(213, 53);
            this.axWindowsMediaPlayer1.TabIndex = 17;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UppLink.Countdown.Properties.Resources.small;
            this.pictureBox1.Location = new System.Drawing.Point(198, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BackOnlyLastSecBox);
            this.groupBox4.Controls.Add(this.BackOnlyLastCheck);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.BackOnlyLastMinBox);
            this.groupBox4.Controls.Add(this.BackSoundEnableCheck);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(13, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 46);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "背景声音";
            // 
            // BackOnlyLastSecBox
            // 
            this.BackOnlyLastSecBox.Enabled = false;
            this.BackOnlyLastSecBox.Location = new System.Drawing.Point(207, 18);
            this.BackOnlyLastSecBox.Name = "BackOnlyLastSecBox";
            this.BackOnlyLastSecBox.Size = new System.Drawing.Size(23, 21);
            this.BackOnlyLastSecBox.TabIndex = 20;
            this.BackOnlyLastSecBox.Text = "5";
            // 
            // BackOnlyLastCheck
            // 
            this.BackOnlyLastCheck.AutoSize = true;
            this.BackOnlyLastCheck.Location = new System.Drawing.Point(77, 20);
            this.BackOnlyLastCheck.Name = "BackOnlyLastCheck";
            this.BackOnlyLastCheck.Size = new System.Drawing.Size(72, 16);
            this.BackOnlyLastCheck.TabIndex = 12;
            this.BackOnlyLastCheck.Text = "仅持续到";
            this.BackOnlyLastCheck.UseVisualStyleBackColor = true;
            this.BackOnlyLastCheck.CheckedChanged += new System.EventHandler(this.BackOnlyLastCheck_EnableCheckedChanged);
            this.BackOnlyLastCheck.EnabledChanged += new System.EventHandler(this.BackOnlyLastCheck_EnableCheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "分";
            // 
            // BackOnlyLastMinBox
            // 
            this.BackOnlyLastMinBox.Enabled = false;
            this.BackOnlyLastMinBox.Location = new System.Drawing.Point(155, 18);
            this.BackOnlyLastMinBox.Name = "BackOnlyLastMinBox";
            this.BackOnlyLastMinBox.Size = new System.Drawing.Size(23, 21);
            this.BackOnlyLastMinBox.TabIndex = 17;
            this.BackOnlyLastMinBox.Text = "0";
            // 
            // BackSoundEnableCheck
            // 
            this.BackSoundEnableCheck.AutoSize = true;
            this.BackSoundEnableCheck.Checked = true;
            this.BackSoundEnableCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BackSoundEnableCheck.Location = new System.Drawing.Point(10, 20);
            this.BackSoundEnableCheck.Name = "BackSoundEnableCheck";
            this.BackSoundEnableCheck.Size = new System.Drawing.Size(48, 16);
            this.BackSoundEnableCheck.TabIndex = 11;
            this.BackSoundEnableCheck.Text = "开启";
            this.BackSoundEnableCheck.UseVisualStyleBackColor = true;
            this.BackSoundEnableCheck.CheckedChanged += new System.EventHandler(this.BackSoundEnableCheck_EnableCheckedChanged);
            this.BackSoundEnableCheck.EnabledChanged += new System.EventHandler(this.BackSoundEnableCheck_EnableCheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "秒";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 306);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Designed By EdwardYin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }






        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.TextBox TimeBoxMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox Countdown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TimeBoxSec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox AlertBoxSec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AlertBoxMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PPTValue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox BackOnlyLastSecBox;
        private System.Windows.Forms.CheckBox BackOnlyLastCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BackOnlyLastMinBox;
        private System.Windows.Forms.CheckBox BackSoundEnableCheck;
        private System.Windows.Forms.Label label7;
    }
}


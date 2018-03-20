using Microsoft.Office.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPT = Microsoft.Office.Interop.PowerPoint;

namespace UppLink.Countdown
{
    public partial class Form1 : Form
    {
        public IList<TimeSpan> alertList;
        bool isCountdown;
        //是否正在显示
        bool isPresentationing = false;
        //是否正在运行计时器
        bool isRunning = false;
        //当前背景声音是否开启
        bool isBackSoundOn = false;
        //背景声音是否只工作一段时间
        bool isBackSoundRunNotAllTime = false;
        //若背景声音不持续工作。工作到时间点
        public TimeSpan BackSoundRunTimeSpan;
        //开始时间点或者结束时间点
        public DateTime TimePoint;
        //偏移量 毫秒
        TimeSpan Offset;
        //背景声音状态
        public SoundType soundtype;
        public PPT.Presentation pp;
        public PPT.Application pa;
        PPT.Shape Timer;
        PPT.Shape Clock;
        string TimerStr = "99:99.99";
        string ClockStr = "99:99:99";
        string FileName;
        public Form1()
        {
            InitializeComponent();
            MyInitComponent();
            pa = new PPT.ApplicationClass();
            readAppSetting();
            InitializeFile();
            alertList = new List<TimeSpan>();
            soundtype = SoundType.NONE;
        }

        private void MyInitComponent()
        {
            this.TimeBoxMin.Validating += Validating_Number;
            this.TimeBoxSec.Validating += Validating_Number;
            this.AlertBoxMin.Validating += Validating_Number;
            this.AlertBoxSec.Validating += Validating_Number;
            this.BackOnlyLastMinBox.Validating += Validating_Number;
            this.BackOnlyLastSecBox.Validating += Validating_Number;
        }


        private void Start_Click(object sender, EventArgs e)
        {
            if (Start.Text.Equals("暂停计时"))
            {
                Start.Text = "继续计时";
                toPause();
            }
            else if (Start.Text.Equals("继续计时"))
            {
                Start.Text = "暂停计时";
                toResume();
            }
            else
            {
                Start.Text = "暂停计时";
                toStart();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (!Display.Text.Equals("显示界面"))
            {
                Display_Click(sender, e);
            }
            toStop();
            Start.Text = "开始计时";
        }


        private void Form1FormClosing(object sender, System.EventArgs e)
        {
            pp.Close();
            writeAppSetting();
        }

        private void Countdown_EnableCheckedChanged(object sender, EventArgs e)
        {
            if (Countdown.Checked && Countdown.Enabled)
            {
                TimeBoxMin.Enabled = true;
                TimeBoxSec.Enabled = true;
            }
            else
            {
                TimeBoxMin.Enabled = false;
                TimeBoxSec.Enabled = false;
            }
        }
        private void Display_Click(object sender, EventArgs e)
        {

            if (Display.Text.Equals("显示界面"))
            {
                Display.Text = "隐藏界面";
                toVisible();
            }
            else
            {
                Display.Text = "显示界面";
                toUnVisible();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            TimeSpan temp = new TimeSpan(0, int.Parse(AlertBoxMin.Text), int.Parse(AlertBoxSec.Text));
            foreach (var item in listBox1.Items)
	        {
                if(temp.Equals(item))
                {
                    return;
                }
	        }
            listBox1.Items.Add(temp);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

        }
        private void BackSoundEnableCheck_EnableCheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Enabled && ((CheckBox)sender).Checked)
            {
                this.BackOnlyLastCheck.Enabled = true;
            }
            else
            {
                this.BackOnlyLastCheck.Enabled = false;
            }
        }

        private void BackOnlyLastCheck_EnableCheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Enabled  && ((CheckBox)sender).Checked )
            {
                BackOnlyLastMinBox.Enabled = true;
                BackOnlyLastSecBox.Enabled = true;
            }
            else
            {
                BackOnlyLastMinBox.Enabled = false;
                BackOnlyLastSecBox.Enabled = false;
            }
        }
    }
}

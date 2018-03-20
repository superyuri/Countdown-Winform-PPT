using Microsoft.Office.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPT = Microsoft.Office.Interop.PowerPoint;
//WindowsPlayerHelper
//http://www.cnblogs.com/Garden-blog/archive/2011/04/15/2017362.html
namespace UppLink.Countdown
{
    public partial class Form1 : Form
    {

        private void readAppSetting()
        {
            try
            {
                string temp = AppConfigHelper.GetConfig("Title");
                this.Text = (temp == "" ? "Designed" : temp) + " by EdwardYin";
                temp = AppConfigHelper.GetConfig("PPTFileName");
                this.FileName = (temp == "" ? @"Timer.pptx" : temp);
                this.TimeBoxMin.Text = int.Parse(AppConfigHelper.GetConfig("TimeMin")) + "";
                this.TimeBoxSec.Text = int.Parse(AppConfigHelper.GetConfig("TimeSec")) + "";
                this.AlertBoxMin.Text = int.Parse(AppConfigHelper.GetConfig("AlertMin")) + "";
                this.AlertBoxSec.Text = int.Parse(AppConfigHelper.GetConfig("AlertSec")) + "";
                this.BackOnlyLastMinBox.Text = int.Parse(AppConfigHelper.GetConfig("BackOnlyLastMinBox")) + "";
                this.BackOnlyLastSecBox.Text = int.Parse(AppConfigHelper.GetConfig("BackOnlyLastSecBox")) + "";
                this.Countdown.Checked = bool.Parse(AppConfigHelper.GetConfig("IsCountDown"));
                this.BackSoundEnableCheck.Checked = bool.Parse(AppConfigHelper.GetConfig("BackSoundEnableCheck"));
                this.BackOnlyLastCheck.Checked = bool.Parse(AppConfigHelper.GetConfig("BackOnlyLastCheck"));
            }
            catch
            {
            }
        }
        private void writeAppSetting()
        {
            AppConfigHelper.SetConfig("TimeMin", TimeBoxMin.Text);
            AppConfigHelper.SetConfig("TimeSec", TimeBoxSec.Text);
            AppConfigHelper.SetConfig("AlertMin", AlertBoxMin.Text);
            AppConfigHelper.SetConfig("AlertSec", AlertBoxSec.Text);
            AppConfigHelper.SetConfig("BackOnlyLastMinBox", BackOnlyLastMinBox.Text);
            AppConfigHelper.SetConfig("BackOnlyLastSecBox", BackOnlyLastSecBox.Text);
            AppConfigHelper.SetConfig("IsCountDown", Countdown.Checked + "");
            AppConfigHelper.SetConfig("BackSoundEnableCheck", BackSoundEnableCheck.Checked + "");
            AppConfigHelper.SetConfig("BackOnlyLastCheck", BackOnlyLastCheck.Checked + "");
        }
        private void InitializeFile()
        {
            try
            {
                pp = pa.Presentations.Open(Application.StartupPath + @".\" + this.FileName, Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse);

                PPT.Slide slide = (PPT.Slide)pp.Slides._Index(1);
                foreach (PPT.Shape shape in slide.Shapes)
                {

                    if (shape.Type == Microsoft.Office.Core.MsoShapeType.msoTextBox)
                    {
                        /*
                         * 
                        PPT.TextFrame frame = shape.TextFrame;//55
                        PPT.TextRange range = frame.TextRange;//56
                        string text = "";
                        try
                        {
                            text = range.Text;//60
                        }
                        catch { }
                        if (text.Contains(this.TimerStr))//58
                         * 
                         * */
                        if(shape.TextFrame.TextRange.Find(this.TimerStr)!=null)
                        //if (shape.TextFrame.TextRange.Text.Contains(this.TimerStr))
                        {
                            Timer = shape;
                        }
                        else if (shape.TextFrame.TextRange.Find(this.ClockStr) != null)
                        //else if (text.Contains(this.ClockStr))
                        //else if (shape.TextFrame.TextRange.Text.Contains(this.ClockStr))
                        {
                            Clock = shape;
                        }
                    }
                }
                if (Timer == null || Clock == null)
                {
                    throw new Exception("时间标记没找到");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("打开失败。 "+e.Message+"\n"+e.StackTrace, "错误", MessageBoxButtons.OK);
                Application.Exit();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //倒计时结束
            if (isCountdown && DateTime.Now > TimePoint)
            {
                timer1.Stop();
                Timer.TextFrame.TextRange.Text = TimeSpan.Zero.ToString(@"mm\:ss\.ff");
                PPTValue.Text = TimeSpan.Zero.ToString(@"mm\:ss\.ff");

                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.URL = @".\Done.wav";
                axWindowsMediaPlayer1.settings.setMode("loop", false);
                axWindowsMediaPlayer1.Ctlcontrols.play();

                Start.Enabled = false;
                soundtype = SoundType.ENDING;
                return;
            }
            TickPPTText();

        }
        private void initPPTText()
        {
            Timer.TextFrame.TextRange.Text = Offset.ToString(@"mm\:ss\.ff");
            PPTValue.Text = Offset.ToString(@"mm\:ss\.ff");
            Clock.TextFrame.TextRange.Text = DateTime.Now.ToString(@"HH\:mm\:ss");

        }
        private void TickPPTText()
        {
            string result;
            if (isCountdown)
            {
                result = (TimePoint - DateTime.Now).ToString(@"mm\:ss\.ff");
            }
            else
            {
                result = (DateTime.Now - TimePoint + Offset).ToString(@"mm\:ss\.ff");
            }
            Timer.TextFrame.TextRange.Text = result;
            PPTValue.Text = result;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Clock.TextFrame.TextRange.Text = DateTime.Now.ToString(@"HH\:mm\:ss");
            if(isRunning)
            {
                if (isBackSoundOn && soundtype == SoundType.NONE)
                {
                    axWindowsMediaPlayer1.URL = @".\ClockLoop.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    soundtype = SoundType.CLOCK;
                }
                if (isBackSoundOn && isBackSoundRunNotAllTime)
                {
                    if (isCountdown)
                    {
                        if (TimePoint - DateTime.Now < BackSoundRunTimeSpan)
                        {
                            axWindowsMediaPlayer1.Ctlcontrols.stop();
                            soundtype = SoundType.NONE;
                            isBackSoundOn = false;
                        }
                    }
                    else
                    {
                        if (DateTime.Now - TimePoint + Offset > BackSoundRunTimeSpan)
                        {
                            axWindowsMediaPlayer1.Ctlcontrols.stop();
                            soundtype = SoundType.NONE;
                            isBackSoundOn = false;
                        }
                    }
                }
                foreach (var item in listBox1.Items)
                {
                    if (item is TimeSpan)
                    {
                        if (isCountdown)
                        {
                            if (((TimeSpan)item) > TimePoint - DateTime.Now)
                            {
                                listBox1.Items.Remove(item);
                                axWindowsMediaPlayer1.URL = @".\Alert.mp3";
                                axWindowsMediaPlayer1.settings.setMode("loop", false);
                                soundtype = SoundType.ALERT;
                                return;
                            }
                        }
                        else
                        {
                            if (((TimeSpan)item) < DateTime.Now - TimePoint + Offset)
                            {
                                listBox1.Items.Remove(item);
                                axWindowsMediaPlayer1.URL = @".\Alert.mp3";
                                axWindowsMediaPlayer1.settings.setMode("loop", false);
                                soundtype = SoundType.ALERT;
                                return;

                            }
                        }
                    }
                }
            }
        }

        void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped && soundtype == SoundType.ALERT)
            {
                soundtype = SoundType.NONE;
            }
        }
        private void toVisible()
        {
            if (isPresentationing)
            {
                pa.ActivePresentation.SlideShowWindow.Top = 0;
                pa.ActivePresentation.SlideShowWindow.Activate(); //需重新激活，否则会跑到下层  
            }
            else
            {
                isPresentationing = true;
                Start.Enabled = true;
                CloseButton.Enabled = true;
                //TimeBoxMin.Enabled = false;
                //TimeBoxSec.Enabled = false;
                AlertBoxMin.Enabled = false;
                AlertBoxSec.Enabled = false;
                BackSoundEnableCheck.Enabled = false;
                Add.Enabled = false;
                Remove.Enabled = false;
                listBox1.Enabled = false;
                Countdown.Enabled = false;

                isCountdown = Countdown.Checked;
                isBackSoundOn = BackSoundEnableCheck.Checked;
                isBackSoundRunNotAllTime = BackOnlyLastCheck.Checked;
                BackSoundRunTimeSpan = new TimeSpan(0,int.Parse(BackOnlyLastMinBox.Text), int.Parse(BackOnlyLastSecBox.Text));
                if (isCountdown)
                {
                    Offset = new TimeSpan(0, int.Parse(TimeBoxMin.Text), int.Parse(TimeBoxSec.Text));
                }
                else
                {
                    Offset = new TimeSpan(0, 0, 0);
                }

                initPPTText();
                pp.SlideShowSettings.LoopUntilStopped = MsoTriState.msoFalse;
                pp.SlideShowSettings.Run();

                timer2.Start();
                alertList.Clear();
                foreach (var item in listBox1.Items)
	            {
                    if (item is TimeSpan)
                    {
                        alertList.Add((TimeSpan)item);
                    }
	            }
                
            }
        }
        private void toUnVisible()
        {
            pa.ActivePresentation.SlideShowWindow.Top = 3000;
        }
        private void toStart()
        {
            timer1.Start();

            if (isCountdown)
            {
                TimePoint = DateTime.Now + Offset;
            }
            else
            {
                TimePoint = DateTime.Now;
            }
            isRunning = true;

            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
        }
        private void toPause()
        {
            timer1.Stop();
            if (isCountdown)
            {
                Offset = TimePoint - DateTime.Now;
            }
            else
            {
                Offset = DateTime.Now - TimePoint + Offset;
            }

        }
        private void toResume()
        {
            timer1.Start();
            if (isCountdown)
            {
                TimePoint = DateTime.Now + Offset;
            }
            else
            {
                TimePoint = DateTime.Now;
            }
        }
        private void toStop()
        {
            if (isPresentationing)
            {
                timer1.Stop();
                timer2.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            CloseButton.Enabled = false;
            Start.Enabled = false;
            //TimeBoxMin.Enabled = true;
            //TimeBoxSec.Enabled = true;
            AlertBoxMin.Enabled = true;
            AlertBoxSec.Enabled = true;
            BackSoundEnableCheck.Enabled = true;
            Add.Enabled = true;
            isPresentationing = false;
            isRunning = false;
            Remove.Enabled = true;
            listBox1.Enabled = true;
            Countdown.Enabled = true;
            
            pp.Close();
            InitializeFile();
            listBox1.Items.Clear();
            foreach (var item in alertList)
            {
                listBox1.Items.Add(item);
            }
            soundtype = SoundType.NONE;

            axWindowsMediaPlayer1.PlayStateChange -= axWindowsMediaPlayer1_PlayStateChange;
        }

        private void Validating_Number(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox obj = (TextBox)sender;
                try
                {
                    int.Parse(obj.Text);
                    this.errorProvider1.Clear();
                }
                catch
                {
                    e.Cancel = true;
                    obj.Select(0, obj.Text.Length);

                    // Set the ErrorProvider error with the text to display. 
                    this.errorProvider1.SetError(obj, "数字输入错误");
                }
            }
        }



        
    }
}
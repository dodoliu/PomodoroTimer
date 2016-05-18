using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class PomodoroTimer : Form
    {
        private int iDateMinute = 0;
        private int iDateSecond = 0;

        private System.Timers.Timer mainTimer = null;

        //工作时间
        private System.Timers.Timer workTimer = null;
        //休息时间
        private System.Timers.Timer breakTimer = null;

        #region Test
        //每次工作30分钟
        private int iWorkInterval = 1000 * 10;
        //每次休息5分钟
        private int iBreakInterval = 1000 * 5;
        #endregion

        ////每次工作30分钟
        //private int iWorkInterval = 1000 * 60 * 30;
        ////每次休息5分钟
        //private int iBreakInterval = 1000 * 60 * 5;

        private delegate void MainTimerDelegate();
        private MainTimerDelegate mainTimerDelegate = null;
        private MainTimerDelegate addDatePointDelegate = null;


        public PomodoroTimer()
        {
            InitializeComponent();

            mainTimerDelegate = new MainTimerDelegate(ShowTimerResult);
            addDatePointDelegate = new MainTimerDelegate(AddDatePoint2ListBoxItem);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.btn_start.Enabled = false;
            this.btn_stop.Enabled = true;
            WorkTimerStart();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            this.btn_start.Enabled = true;
            this.btn_stop.Enabled = false;
            DisposeTimer();
        }

        private void WorkTimerStart()
        {
            DisposeTimer();
            MainTimerStart();
            
            InitTimer("work",ref workTimer, iWorkInterval);
        }

        private void WorkTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (CheckAlarmTime())
            {
                MessageBox.Show("啊啊啊啊啊啊,你还不站起来,扭扭脖子动动腿!", "保命提示!请浪5分钟!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                this.Invoke(addDatePointDelegate);

                workTimer.Stop();
                BreakTimerStart();
            }
        }

        private void BreakTimerStart()
        {
            DisposeTimer();
            MainTimerStart();
             
            InitTimer("break",ref breakTimer, iBreakInterval);
        }

        private void BreakTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (CheckAlarmTime())
            {
                MessageBox.Show("休息结束,请干活!", "保命提示!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                breakTimer.Stop();
                WorkTimerStart();
            }
        }

        private void MainTimerStart()
        {
            InitTimer("main",ref mainTimer, 1000);
        }

        private void MainTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke(mainTimerDelegate);
        }

        private void ShowTimerResult()
        {
            iDateSecond++;
            if (iDateSecond % 60 == 0)
            {
                iDateSecond = 0;
                iDateMinute++;
            }

            this.lbl_runtime.Text = string.Format("{0}分{1}秒", iDateMinute, iDateSecond);
        }
        /// <summary>
        /// 往listbox中添加时间点
        /// </summary>
        private void AddDatePoint2ListBoxItem()
        {
            this.lb_date_point.Items.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        /// <summary>
        /// 节约内存
        /// </summary>
        private void DisposeTimer()
        {
            iDateMinute = 0;
            iDateSecond = 0;

            if (workTimer != null)
            {
                workTimer.Stop();
                workTimer.Close();
                workTimer.Dispose();
            }
            if (breakTimer != null)
            {
                breakTimer.Stop();
                breakTimer.Close();
                breakTimer.Dispose();
            }
            if (mainTimer != null)
            {
                mainTimer.Stop();
                mainTimer.Close();
                mainTimer.Dispose();
            }
        }

        private void InitTimer(string name,ref System.Timers.Timer timer,int iInterval)
        {
            timer = new System.Timers.Timer();
            timer.Interval = iInterval;
            timer.Enabled = true;
            switch(name)
            {
                case "main":
                    timer.Elapsed += MainTimer_Elapsed;
                    break;
                case "work":
                    timer.Elapsed += WorkTimer_Elapsed;
                    break;
                case "break":
                    timer.Elapsed += BreakTimer_Elapsed;
                    break;
            }

        }

        private void PomodoroTimer_SizeChanged(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Minimized)
            {
                Hide();
                ni_pomodorotimer.Visible = true;
            }
        }

        private void ni_pomodorotimer_Click(object sender, EventArgs e)
        {
            Visible = true;
            WindowState = FormWindowState.Normal;
            ni_pomodorotimer.Visible = false;
        }

        private void PomodoroTimer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定关闭吗?", "关闭", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr==DialogResult.OK)
            {
                DisposeTimer();
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 如果是晚上的10点到早上的9点,不报警
        /// </summary>
        /// <returns></returns>
        public bool CheckAlarmTime()
        {
            bool _bool = true;
            DateTime nowTime = DateTime.Now;
            DateTime beginTime = new DateTime(nowTime.Year, nowTime.Month, nowTime.Day, 22, 0, 0);
            DateTime nowTimeEnd = beginTime.AddDays(1);
            DateTime endTime = new DateTime(nowTimeEnd.Year, nowTimeEnd.Month, nowTimeEnd.Day, 9, 0, 0);
            if (nowTime >= beginTime && nowTime <= endTime)
            {
                _bool = false;
            }
            return _bool;
        }


    }
}

namespace PomodoroTimer
{
    partial class PomodoroTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PomodoroTimer));
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lbl_runtime = new System.Windows.Forms.Label();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.lb_date_point = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ni_pomodorotimer = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(58, 34);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(58, 63);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "停止";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lbl_runtime
            // 
            this.lbl_runtime.AutoSize = true;
            this.lbl_runtime.Location = new System.Drawing.Point(128, 9);
            this.lbl_runtime.Name = "lbl_runtime";
            this.lbl_runtime.Size = new System.Drawing.Size(11, 12);
            this.lbl_runtime.TabIndex = 3;
            this.lbl_runtime.Text = "0";
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Location = new System.Drawing.Point(39, 9);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(59, 12);
            this.lbl_tip.TabIndex = 4;
            this.lbl_tip.Text = "运行时间:";
            // 
            // lb_date_point
            // 
            this.lb_date_point.FormattingEnabled = true;
            this.lb_date_point.ItemHeight = 12;
            this.lb_date_point.Location = new System.Drawing.Point(6, 20);
            this.lb_date_point.Name = "lb_date_point";
            this.lb_date_point.Size = new System.Drawing.Size(164, 352);
            this.lb_date_point.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_date_point);
            this.groupBox1.Location = new System.Drawing.Point(9, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 383);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "运行记录";
            // 
            // ni_pomodorotimer
            // 
            this.ni_pomodorotimer.Icon = ((System.Drawing.Icon)(resources.GetObject("ni_pomodorotimer.Icon")));
            this.ni_pomodorotimer.Text = "notifyIcon1";
            this.ni_pomodorotimer.Visible = true;
            this.ni_pomodorotimer.Click += new System.EventHandler(this.ni_pomodorotimer_Click);
            // 
            // PomodoroTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_tip);
            this.Controls.Add(this.lbl_runtime);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PomodoroTimer";
            this.ShowInTaskbar = false;
            this.Text = "番茄闹钟";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PomodoroTimer_FormClosing);
            this.SizeChanged += new System.EventHandler(this.PomodoroTimer_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lbl_runtime;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.ListBox lb_date_point;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NotifyIcon ni_pomodorotimer;
    }
}


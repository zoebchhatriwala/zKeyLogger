namespace zKeyLogger
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.log = new System.Windows.Forms.TextBox();
            this.copy = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.key = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.log.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.log.Location = new System.Drawing.Point(12, 12);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(524, 232);
            this.log.TabIndex = 0;
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(118, 250);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(100, 23);
            this.copy.TabIndex = 1;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(224, 250);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(100, 23);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(330, 250);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(100, 23);
            this.about.TabIndex = 3;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 250);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 23);
            this.start.TabIndex = 4;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(12, 250);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(100, 23);
            this.stop.TabIndex = 5;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Visible = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // key
            // 
            this.key.Interval = 10;
            this.key.Tick += new System.EventHandler(this.key_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Runnig Here";
            this.notifyIcon1.BalloonTipTitle = "zKeyLogger";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Hide
            // 
            this.Hide.Location = new System.Drawing.Point(436, 250);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(100, 23);
            this.Hide.TabIndex = 6;
            this.Hide.Text = "Hide";
            this.Hide.UseVisualStyleBackColor = true;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(548, 289);
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.about);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(564, 328);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(564, 328);
            this.Name = "Home";
            this.ShowIcon = false;
            this.Text = "zKeyLogger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Timer key;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button Hide;
    }
}


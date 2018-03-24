namespace cam_aforge1
{
    partial class GUI
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
            this.viewFinder = new System.Windows.Forms.PictureBox();
            this.vidSrc = new System.Windows.Forms.ComboBox();
            this.vidSrcLabel = new System.Windows.Forms.Label();
            this.rfsh = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.fps = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ctrl = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.countDisp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewFinder)).BeginInit();
            this.fps.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewFinder
            // 
            this.viewFinder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewFinder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewFinder.Location = new System.Drawing.Point(196, 9);
            this.viewFinder.Name = "viewFinder";
            this.viewFinder.Size = new System.Drawing.Size(692, 476);
            this.viewFinder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewFinder.TabIndex = 0;
            this.viewFinder.TabStop = false;
            this.viewFinder.Click += new System.EventHandler(this.viewFinder_Click);
            this.viewFinder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viewFinder_FindClick);
            // 
            // vidSrc
            // 
            this.vidSrc.FormattingEnabled = true;
            this.vidSrc.Location = new System.Drawing.Point(12, 26);
            this.vidSrc.Name = "vidSrc";
            this.vidSrc.Size = new System.Drawing.Size(157, 21);
            this.vidSrc.TabIndex = 1;
            // 
            // vidSrcLabel
            // 
            this.vidSrcLabel.AutoSize = true;
            this.vidSrcLabel.Location = new System.Drawing.Point(9, 9);
            this.vidSrcLabel.Name = "vidSrcLabel";
            this.vidSrcLabel.Size = new System.Drawing.Size(101, 13);
            this.vidSrcLabel.TabIndex = 2;
            this.vidSrcLabel.Text = "Select video source";
            // 
            // rfsh
            // 
            this.rfsh.Location = new System.Drawing.Point(13, 62);
            this.rfsh.Name = "rfsh";
            this.rfsh.Size = new System.Drawing.Size(68, 31);
            this.rfsh.TabIndex = 3;
            this.rfsh.Text = "&Refresh";
            this.rfsh.UseVisualStyleBackColor = true;
            this.rfsh.Click += new System.EventHandler(this.rfsh_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(101, 62);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(68, 31);
            this.start.TabIndex = 4;
            this.start.Text = "&Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // fps
            // 
            this.fps.Controls.Add(this.label2);
            this.fps.Location = new System.Drawing.Point(12, 144);
            this.fps.Name = "fps";
            this.fps.Size = new System.Drawing.Size(155, 28);
            this.fps.TabIndex = 6;
            this.fps.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Device ready..";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctrl
            // 
            this.ctrl.Location = new System.Drawing.Point(12, 99);
            this.ctrl.Name = "ctrl";
            this.ctrl.Size = new System.Drawing.Size(68, 31);
            this.ctrl.TabIndex = 7;
            this.ctrl.Text = "&Control";
            this.ctrl.UseVisualStyleBackColor = true;
            this.ctrl.Click += new System.EventHandler(this.ctrl_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 191);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "Tick";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(22, 239);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(75, 25);
            this.countLabel.TabIndex = 11;
            this.countLabel.Text = "Count:";
            // 
            // countDisp
            // 
            this.countDisp.AutoSize = true;
            this.countDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDisp.Location = new System.Drawing.Point(96, 239);
            this.countDisp.Name = "countDisp";
            this.countDisp.Size = new System.Drawing.Size(24, 25);
            this.countDisp.TabIndex = 12;
            this.countDisp.Text = "0";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 497);
            this.Controls.Add(this.countDisp);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ctrl);
            this.Controls.Add(this.fps);
            this.Controls.Add(this.start);
            this.Controls.Add(this.rfsh);
            this.Controls.Add(this.vidSrcLabel);
            this.Controls.Add(this.vidSrc);
            this.Controls.Add(this.viewFinder);
            this.Name = "GUI";
            this.Text = "Orthoscope/Arthroscope Camera";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.viewFinder)).EndInit();
            this.fps.ResumeLayout(false);
            this.fps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox viewFinder;
        private System.Windows.Forms.ComboBox vidSrc;
        private System.Windows.Forms.Label vidSrcLabel;
        private System.Windows.Forms.Button rfsh;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.GroupBox fps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ctrl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label countDisp;
    }
}


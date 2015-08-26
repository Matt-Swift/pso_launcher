namespace PsoWindowSize
{
    partial class frmResizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResizer));
            this.cmdResize = new System.Windows.Forms.Button();
            this.cboRatio = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAutoResize = new System.Windows.Forms.CheckBox();
            this.rdoCustom = new System.Windows.Forms.RadioButton();
            this.fraCustom = new System.Windows.Forms.GroupBox();
            this.chkLockRatio = new System.Windows.Forms.CheckBox();
            this.lblRatio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.NumericUpDown();
            this.rdoPerfect = new System.Windows.Forms.RadioButton();
            this.lblPsoStatus = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdOptions = new System.Windows.Forms.Button();
            this.cmdScreenshot = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdStartOffline = new System.Windows.Forms.Button();
            this.cmdStartOnline = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkWindowed = new System.Windows.Forms.CheckBox();
            this.chkVista = new System.Windows.Forms.CheckBox();
            this.chkWhiteNames = new System.Windows.Forms.CheckBox();
            this.chkMusicFix = new System.Windows.Forms.CheckBox();
            this.chkMapFix = new System.Windows.Forms.CheckBox();
            this.chkWordFilter = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.fraCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtW)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdResize
            // 
            this.cmdResize.Location = new System.Drawing.Point(159, 136);
            this.cmdResize.Name = "cmdResize";
            this.cmdResize.Size = new System.Drawing.Size(75, 23);
            this.cmdResize.TabIndex = 7;
            this.cmdResize.Text = "Resize PSO Window";
            this.cmdResize.UseVisualStyleBackColor = true;
            this.cmdResize.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboRatio
            // 
            this.cboRatio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRatio.FormattingEnabled = true;
            this.cboRatio.Items.AddRange(new object[] {
            "1x (640 x 480)",
            "2x (1280 x 960)",
            "3x (1920 x 1440)"});
            this.cboRatio.Location = new System.Drawing.Point(113, 18);
            this.cboRatio.Name = "cboRatio";
            this.cboRatio.Size = new System.Drawing.Size(121, 21);
            this.cboRatio.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAutoResize);
            this.groupBox1.Controls.Add(this.rdoCustom);
            this.groupBox1.Controls.Add(this.fraCustom);
            this.groupBox1.Controls.Add(this.rdoPerfect);
            this.groupBox1.Controls.Add(this.cboRatio);
            this.groupBox1.Controls.Add(this.cmdResize);
            this.groupBox1.Location = new System.Drawing.Point(194, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // chkAutoResize
            // 
            this.chkAutoResize.AutoSize = true;
            this.chkAutoResize.Location = new System.Drawing.Point(6, 140);
            this.chkAutoResize.Name = "chkAutoResize";
            this.chkAutoResize.Size = new System.Drawing.Size(83, 17);
            this.chkAutoResize.TabIndex = 8;
            this.chkAutoResize.Text = "Auto Resize";
            this.chkAutoResize.UseVisualStyleBackColor = true;
            // 
            // rdoCustom
            // 
            this.rdoCustom.AutoSize = true;
            this.rdoCustom.Location = new System.Drawing.Point(6, 46);
            this.rdoCustom.Name = "rdoCustom";
            this.rdoCustom.Size = new System.Drawing.Size(83, 17);
            this.rdoCustom.TabIndex = 3;
            this.rdoCustom.TabStop = true;
            this.rdoCustom.Text = "Custom Size";
            this.rdoCustom.UseVisualStyleBackColor = true;
            this.rdoCustom.CheckedChanged += new System.EventHandler(this.rdoCustom_CheckedChanged);
            // 
            // fraCustom
            // 
            this.fraCustom.Controls.Add(this.chkLockRatio);
            this.fraCustom.Controls.Add(this.lblRatio);
            this.fraCustom.Controls.Add(this.label2);
            this.fraCustom.Controls.Add(this.txtH);
            this.fraCustom.Controls.Add(this.label1);
            this.fraCustom.Controls.Add(this.txtW);
            this.fraCustom.Enabled = false;
            this.fraCustom.Location = new System.Drawing.Point(7, 48);
            this.fraCustom.Name = "fraCustom";
            this.fraCustom.Size = new System.Drawing.Size(227, 82);
            this.fraCustom.TabIndex = 7;
            this.fraCustom.TabStop = false;
            // 
            // chkLockRatio
            // 
            this.chkLockRatio.AutoSize = true;
            this.chkLockRatio.Checked = true;
            this.chkLockRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLockRatio.Location = new System.Drawing.Point(106, 58);
            this.chkLockRatio.Name = "chkLockRatio";
            this.chkLockRatio.Size = new System.Drawing.Size(78, 17);
            this.chkLockRatio.TabIndex = 6;
            this.chkLockRatio.Text = "Lock Ratio";
            this.chkLockRatio.UseVisualStyleBackColor = true;
            // 
            // lblRatio
            // 
            this.lblRatio.AutoSize = true;
            this.lblRatio.Location = new System.Drawing.Point(128, 42);
            this.lblRatio.Name = "lblRatio";
            this.lblRatio.Size = new System.Drawing.Size(38, 13);
            this.lblRatio.TabIndex = 8;
            this.lblRatio.Text = "Ratio: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dimensions:";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(173, 19);
            this.txtH.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.txtH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(48, 20);
            this.txtH.TabIndex = 5;
            this.txtH.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.txtH.ValueChanged += new System.EventHandler(this.txtH_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "x";
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(106, 19);
            this.txtW.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.txtW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(48, 20);
            this.txtW.TabIndex = 4;
            this.txtW.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.txtW.ValueChanged += new System.EventHandler(this.txtW_ValueChanged);
            // 
            // rdoPerfect
            // 
            this.rdoPerfect.AutoSize = true;
            this.rdoPerfect.Checked = true;
            this.rdoPerfect.Location = new System.Drawing.Point(6, 19);
            this.rdoPerfect.Name = "rdoPerfect";
            this.rdoPerfect.Size = new System.Drawing.Size(102, 17);
            this.rdoPerfect.TabIndex = 1;
            this.rdoPerfect.TabStop = true;
            this.rdoPerfect.Text = "4:3 Pixel Perfect";
            this.rdoPerfect.UseVisualStyleBackColor = true;
            this.rdoPerfect.CheckedChanged += new System.EventHandler(this.rdoPerfect_CheckedChanged);
            // 
            // lblPsoStatus
            // 
            this.lblPsoStatus.AutoSize = true;
            this.lblPsoStatus.Location = new System.Drawing.Point(12, 183);
            this.lblPsoStatus.Name = "lblPsoStatus";
            this.lblPsoStatus.Size = new System.Drawing.Size(103, 13);
            this.lblPsoStatus.TabIndex = 8;
            this.lblPsoStatus.Text = "PSO is NOT running";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdOptions);
            this.groupBox2.Controls.Add(this.cmdScreenshot);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 111);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tools";
            // 
            // cmdOptions
            // 
            this.cmdOptions.Location = new System.Drawing.Point(43, 63);
            this.cmdOptions.Name = "cmdOptions";
            this.cmdOptions.Size = new System.Drawing.Size(87, 23);
            this.cmdOptions.TabIndex = 1;
            this.cmdOptions.Text = "Options";
            this.cmdOptions.UseVisualStyleBackColor = true;
            this.cmdOptions.Click += new System.EventHandler(this.cmdOptions_Click);
            // 
            // cmdScreenshot
            // 
            this.cmdScreenshot.Location = new System.Drawing.Point(43, 33);
            this.cmdScreenshot.Name = "cmdScreenshot";
            this.cmdScreenshot.Size = new System.Drawing.Size(87, 23);
            this.cmdScreenshot.TabIndex = 0;
            this.cmdScreenshot.Text = "Screenshot";
            this.cmdScreenshot.UseVisualStyleBackColor = true;
            this.cmdScreenshot.Click += new System.EventHandler(this.cmdScreenshot_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdStartOffline);
            this.groupBox3.Controls.Add(this.cmdStartOnline);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 51);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Launcher";
            // 
            // cmdStartOffline
            // 
            this.cmdStartOffline.Location = new System.Drawing.Point(95, 16);
            this.cmdStartOffline.Name = "cmdStartOffline";
            this.cmdStartOffline.Size = new System.Drawing.Size(75, 23);
            this.cmdStartOffline.TabIndex = 1;
            this.cmdStartOffline.Text = "Offline";
            this.cmdStartOffline.UseVisualStyleBackColor = true;
            this.cmdStartOffline.Click += new System.EventHandler(this.cmdStartOffline_Click);
            // 
            // cmdStartOnline
            // 
            this.cmdStartOnline.Location = new System.Drawing.Point(6, 16);
            this.cmdStartOnline.Name = "cmdStartOnline";
            this.cmdStartOnline.Size = new System.Drawing.Size(75, 23);
            this.cmdStartOnline.TabIndex = 0;
            this.cmdStartOnline.Text = "Online";
            this.cmdStartOnline.UseVisualStyleBackColor = true;
            this.cmdStartOnline.Click += new System.EventHandler(this.cmdStartOnline_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // chkWindowed
            // 
            this.chkWindowed.AutoSize = true;
            this.chkWindowed.Location = new System.Drawing.Point(200, 11);
            this.chkWindowed.Name = "chkWindowed";
            this.chkWindowed.Size = new System.Drawing.Size(77, 17);
            this.chkWindowed.TabIndex = 11;
            this.chkWindowed.Text = "Windowed";
            this.chkWindowed.UseVisualStyleBackColor = true;
            // 
            // chkVista
            // 
            this.chkVista.AutoSize = true;
            this.chkVista.Location = new System.Drawing.Point(252, 186);
            this.chkVista.Name = "chkVista";
            this.chkVista.Size = new System.Drawing.Size(150, 17);
            this.chkVista.TabIndex = 12;
            this.chkVista.Text = "Disable IME (Vista or later)";
            this.chkVista.UseVisualStyleBackColor = true;
            // 
            // chkWhiteNames
            // 
            this.chkWhiteNames.AutoSize = true;
            this.chkWhiteNames.Location = new System.Drawing.Point(252, 233);
            this.chkWhiteNames.Name = "chkWhiteNames";
            this.chkWhiteNames.Size = new System.Drawing.Size(175, 17);
            this.chkWhiteNames.TabIndex = 13;
            this.chkWhiteNames.Text = "PSO v1 and GC names in white";
            this.chkWhiteNames.UseVisualStyleBackColor = true;
            // 
            // chkMusicFix
            // 
            this.chkMusicFix.AutoSize = true;
            this.chkMusicFix.Location = new System.Drawing.Point(252, 257);
            this.chkMusicFix.Name = "chkMusicFix";
            this.chkMusicFix.Size = new System.Drawing.Size(162, 17);
            this.chkMusicFix.TabIndex = 14;
            this.chkMusicFix.Text = "Battle music in normal quests";
            this.chkMusicFix.UseVisualStyleBackColor = true;
            // 
            // chkMapFix
            // 
            this.chkMapFix.AutoSize = true;
            this.chkMapFix.Location = new System.Drawing.Point(252, 281);
            this.chkMapFix.Name = "chkMapFix";
            this.chkMapFix.Size = new System.Drawing.Size(129, 17);
            this.chkMapFix.TabIndex = 15;
            this.chkMapFix.Text = "Ultimate mode map fix";
            this.chkMapFix.UseVisualStyleBackColor = true;
            // 
            // chkWordFilter
            // 
            this.chkWordFilter.AutoSize = true;
            this.chkWordFilter.Location = new System.Drawing.Point(252, 210);
            this.chkWordFilter.Name = "chkWordFilter";
            this.chkWordFilter.Size = new System.Drawing.Size(109, 17);
            this.chkWordFilter.TabIndex = 16;
            this.chkWordFilter.Text = "Disable word filter";
            this.chkWordFilter.UseVisualStyleBackColor = true;
            // 
            // frmResizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 380);
            this.Controls.Add(this.chkWordFilter);
            this.Controls.Add(this.chkMapFix);
            this.Controls.Add(this.chkMusicFix);
            this.Controls.Add(this.chkWhiteNames);
            this.Controls.Add(this.chkVista);
            this.Controls.Add(this.chkWindowed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPsoStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResizer";
            this.Text = "PSO Aspect Ratio Correct";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.fraCustom.ResumeLayout(false);
            this.fraCustom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtW)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdResize;
        private System.Windows.Forms.ComboBox cboRatio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoCustom;
        private System.Windows.Forms.GroupBox fraCustom;
        private System.Windows.Forms.CheckBox chkLockRatio;
        private System.Windows.Forms.Label lblRatio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtW;
        private System.Windows.Forms.RadioButton rdoPerfect;
        private System.Windows.Forms.Label lblPsoStatus;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdScreenshot;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdStartOffline;
        private System.Windows.Forms.Button cmdStartOnline;
        private System.Windows.Forms.CheckBox chkAutoResize;
        private System.Windows.Forms.Button cmdOptions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkWindowed;
        private System.Windows.Forms.CheckBox chkVista;
        private System.Windows.Forms.CheckBox chkWhiteNames;
        private System.Windows.Forms.CheckBox chkMusicFix;
        private System.Windows.Forms.CheckBox chkMapFix;
        private System.Windows.Forms.CheckBox chkWordFilter;
    }
}


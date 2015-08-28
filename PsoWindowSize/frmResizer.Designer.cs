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
            this.fraWindowed = new System.Windows.Forms.GroupBox();
            this.chkCenterWindow = new System.Windows.Forms.CheckBox();
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
            this.cboRatio = new System.Windows.Forms.ComboBox();
            this.lblPsoStatus = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdOptions = new System.Windows.Forms.Button();
            this.cmdSerial = new System.Windows.Forms.Button();
            this.cmdScreenshot = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoOffline = new System.Windows.Forms.RadioButton();
            this.rdoOnline = new System.Windows.Forms.RadioButton();
            this.cmdLaunch = new System.Windows.Forms.Button();
            this.cmdStartOffline = new System.Windows.Forms.Button();
            this.cmdStartOnline = new System.Windows.Forms.Button();
            this.fraPatches = new System.Windows.Forms.GroupBox();
            this.chkVista = new System.Windows.Forms.CheckBox();
            this.chkWhiteNames = new System.Windows.Forms.CheckBox();
            this.chkMusicFix = new System.Windows.Forms.CheckBox();
            this.chkWordFilter = new System.Windows.Forms.CheckBox();
            this.chkMapFix = new System.Windows.Forms.CheckBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.chkWindowed = new System.Windows.Forms.CheckBox();
            this.fraWindowed.SuspendLayout();
            this.fraCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtW)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.fraPatches.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdResize
            // 
            this.cmdResize.Location = new System.Drawing.Point(86, 166);
            this.cmdResize.Name = "cmdResize";
            this.cmdResize.Size = new System.Drawing.Size(75, 23);
            this.cmdResize.TabIndex = 7;
            this.cmdResize.Text = "Resize PSO Window";
            this.cmdResize.UseVisualStyleBackColor = true;
            this.cmdResize.Click += new System.EventHandler(this.button1_Click);
            // 
            // fraWindowed
            // 
            this.fraWindowed.Controls.Add(this.chkCenterWindow);
            this.fraWindowed.Controls.Add(this.chkAutoResize);
            this.fraWindowed.Controls.Add(this.rdoCustom);
            this.fraWindowed.Controls.Add(this.fraCustom);
            this.fraWindowed.Controls.Add(this.rdoPerfect);
            this.fraWindowed.Controls.Add(this.cboRatio);
            this.fraWindowed.Controls.Add(this.cmdResize);
            this.fraWindowed.Location = new System.Drawing.Point(154, 12);
            this.fraWindowed.Name = "fraWindowed";
            this.fraWindowed.Size = new System.Drawing.Size(241, 202);
            this.fraWindowed.TabIndex = 2;
            this.fraWindowed.TabStop = false;
            // 
            // chkCenterWindow
            // 
            this.chkCenterWindow.AutoSize = true;
            this.chkCenterWindow.Checked = global::PsoWindowSize.Properties.Settings.Default.LaunchCentered;
            this.chkCenterWindow.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PsoWindowSize.Properties.Settings.Default, "LaunchCentered", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkCenterWindow.Location = new System.Drawing.Point(86, 141);
            this.chkCenterWindow.Name = "chkCenterWindow";
            this.chkCenterWindow.Size = new System.Drawing.Size(150, 17);
            this.chkCenterWindow.TabIndex = 11;
            this.chkCenterWindow.Text = "Launch Window Centered";
            this.chkCenterWindow.UseVisualStyleBackColor = true;
            this.chkCenterWindow.CheckStateChanged += new System.EventHandler(this.chkCenterWindow_CheckStateChanged);
            // 
            // chkAutoResize
            // 
            this.chkAutoResize.AutoSize = true;
            this.chkAutoResize.Checked = global::PsoWindowSize.Properties.Settings.Default.AutoResize;
            this.chkAutoResize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoResize.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PsoWindowSize.Properties.Settings.Default, "AutoResize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAutoResize.Location = new System.Drawing.Point(7, 141);
            this.chkAutoResize.Name = "chkAutoResize";
            this.chkAutoResize.Size = new System.Drawing.Size(83, 17);
            this.chkAutoResize.TabIndex = 10;
            this.chkAutoResize.Text = "Auto Resize";
            this.chkAutoResize.UseVisualStyleBackColor = true;
            this.chkAutoResize.CheckStateChanged += new System.EventHandler(this.chkAutoResize_CheckStateChanged);
            // 
            // rdoCustom
            // 
            this.rdoCustom.AutoSize = true;
            this.rdoCustom.Location = new System.Drawing.Point(6, 44);
            this.rdoCustom.Name = "rdoCustom";
            this.rdoCustom.Size = new System.Drawing.Size(83, 17);
            this.rdoCustom.TabIndex = 6;
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
            this.chkLockRatio.Checked = global::PsoWindowSize.Properties.Settings.Default.LockRatio;
            this.chkLockRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLockRatio.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PsoWindowSize.Properties.Settings.Default, "LockRatio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkLockRatio.Location = new System.Drawing.Point(106, 58);
            this.chkLockRatio.Name = "chkLockRatio";
            this.chkLockRatio.Size = new System.Drawing.Size(78, 17);
            this.chkLockRatio.TabIndex = 9;
            this.chkLockRatio.Text = "Lock Ratio";
            this.chkLockRatio.UseVisualStyleBackColor = true;
            this.chkLockRatio.CheckStateChanged += new System.EventHandler(this.chkLockRatio_CheckStateChanged);
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
            this.txtH.TabIndex = 8;
            this.txtH.Value = new decimal(new int[] {
            600,
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
            this.txtW.TabIndex = 7;
            this.txtW.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.txtW.ValueChanged += new System.EventHandler(this.txtW_ValueChanged);
            // 
            // rdoPerfect
            // 
            this.rdoPerfect.AutoSize = true;
            this.rdoPerfect.Checked = global::PsoWindowSize.Properties.Settings.Default.PixelPerfectRez;
            this.rdoPerfect.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PsoWindowSize.Properties.Settings.Default, "PixelPerfectRez", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rdoPerfect.Location = new System.Drawing.Point(6, 19);
            this.rdoPerfect.Name = "rdoPerfect";
            this.rdoPerfect.Size = new System.Drawing.Size(102, 17);
            this.rdoPerfect.TabIndex = 4;
            this.rdoPerfect.TabStop = true;
            this.rdoPerfect.Text = "4:3 Pixel Perfect";
            this.rdoPerfect.UseVisualStyleBackColor = true;
            this.rdoPerfect.CheckedChanged += new System.EventHandler(this.rdoPerfect_CheckedChanged);
            // 
            // cboRatio
            // 
            this.cboRatio.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PsoWindowSize.Properties.Settings.Default, "PresetRezText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cboRatio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRatio.FormattingEnabled = true;
            this.cboRatio.Items.AddRange(new object[] {
            "1x (640 x 480)",
            "2x (1280 x 960)",
            "3x (1920 x 1440)"});
            this.cboRatio.Location = new System.Drawing.Point(113, 18);
            this.cboRatio.Name = "cboRatio";
            this.cboRatio.Size = new System.Drawing.Size(121, 21);
            this.cboRatio.TabIndex = 5;
            this.cboRatio.Text = global::PsoWindowSize.Properties.Settings.Default.PresetRezText;
            this.cboRatio.SelectedIndexChanged += new System.EventHandler(this.cboRatio_SelectedIndexChanged);
            // 
            // lblPsoStatus
            // 
            this.lblPsoStatus.AutoSize = true;
            this.lblPsoStatus.Location = new System.Drawing.Point(18, 359);
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
            this.groupBox2.Controls.Add(this.cmdSerial);
            this.groupBox2.Controls.Add(this.cmdScreenshot);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 114);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tools";
            // 
            // cmdOptions
            // 
            this.cmdOptions.Location = new System.Drawing.Point(18, 49);
            this.cmdOptions.Name = "cmdOptions";
            this.cmdOptions.Size = new System.Drawing.Size(99, 23);
            this.cmdOptions.TabIndex = 13;
            this.cmdOptions.Text = "PSO Options";
            this.cmdOptions.UseVisualStyleBackColor = true;
            this.cmdOptions.Click += new System.EventHandler(this.cmdOptions_Click);
            // 
            // cmdSerial
            // 
            this.cmdSerial.Location = new System.Drawing.Point(18, 78);
            this.cmdSerial.Name = "cmdSerial";
            this.cmdSerial.Size = new System.Drawing.Size(99, 23);
            this.cmdSerial.TabIndex = 14;
            this.cmdSerial.Text = "Manage Serials";
            this.cmdSerial.UseVisualStyleBackColor = true;
            this.cmdSerial.Click += new System.EventHandler(this.cmdSerial_Click);
            // 
            // cmdScreenshot
            // 
            this.cmdScreenshot.Location = new System.Drawing.Point(18, 19);
            this.cmdScreenshot.Name = "cmdScreenshot";
            this.cmdScreenshot.Size = new System.Drawing.Size(99, 23);
            this.cmdScreenshot.TabIndex = 12;
            this.cmdScreenshot.Text = "Screenshot";
            this.cmdScreenshot.UseVisualStyleBackColor = true;
            this.cmdScreenshot.Click += new System.EventHandler(this.cmdScreenshot_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoOffline);
            this.groupBox3.Controls.Add(this.rdoOnline);
            this.groupBox3.Controls.Add(this.cmdLaunch);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 82);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Launcher";
            // 
            // rdoOffline
            // 
            this.rdoOffline.AutoSize = true;
            this.rdoOffline.Location = new System.Drawing.Point(75, 22);
            this.rdoOffline.Name = "rdoOffline";
            this.rdoOffline.Size = new System.Drawing.Size(55, 17);
            this.rdoOffline.TabIndex = 1;
            this.rdoOffline.Text = "Offline";
            this.rdoOffline.UseVisualStyleBackColor = true;
            // 
            // rdoOnline
            // 
            this.rdoOnline.AutoSize = true;
            this.rdoOnline.Checked = global::PsoWindowSize.Properties.Settings.Default.Online;
            this.rdoOnline.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PsoWindowSize.Properties.Settings.Default, "Online", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rdoOnline.Location = new System.Drawing.Point(6, 22);
            this.rdoOnline.Name = "rdoOnline";
            this.rdoOnline.Size = new System.Drawing.Size(55, 17);
            this.rdoOnline.TabIndex = 0;
            this.rdoOnline.TabStop = true;
            this.rdoOnline.Text = "Online";
            this.rdoOnline.UseVisualStyleBackColor = true;
            // 
            // cmdLaunch
            // 
            this.cmdLaunch.Location = new System.Drawing.Point(18, 45);
            this.cmdLaunch.Name = "cmdLaunch";
            this.cmdLaunch.Size = new System.Drawing.Size(99, 23);
            this.cmdLaunch.TabIndex = 2;
            this.cmdLaunch.Text = "Launch";
            this.cmdLaunch.UseVisualStyleBackColor = true;
            this.cmdLaunch.Click += new System.EventHandler(this.cmdLaunch_Click);
            // 
            // cmdStartOffline
            // 
            this.cmdStartOffline.Enabled = false;
            this.cmdStartOffline.Location = new System.Drawing.Point(240, 417);
            this.cmdStartOffline.Name = "cmdStartOffline";
            this.cmdStartOffline.Size = new System.Drawing.Size(75, 23);
            this.cmdStartOffline.TabIndex = 1;
            this.cmdStartOffline.Text = "Offline";
            this.cmdStartOffline.UseVisualStyleBackColor = true;
            this.cmdStartOffline.Click += new System.EventHandler(this.cmdStartOffline_Click);
            // 
            // cmdStartOnline
            // 
            this.cmdStartOnline.Enabled = false;
            this.cmdStartOnline.Location = new System.Drawing.Point(67, 417);
            this.cmdStartOnline.Name = "cmdStartOnline";
            this.cmdStartOnline.Size = new System.Drawing.Size(75, 23);
            this.cmdStartOnline.TabIndex = 0;
            this.cmdStartOnline.Text = "Online";
            this.cmdStartOnline.UseVisualStyleBackColor = true;
            this.cmdStartOnline.Click += new System.EventHandler(this.cmdStartOnline_Click);
            // 
            // fraPatches
            // 
            this.fraPatches.Controls.Add(this.chkVista);
            this.fraPatches.Controls.Add(this.chkWhiteNames);
            this.fraPatches.Controls.Add(this.chkMusicFix);
            this.fraPatches.Controls.Add(this.chkWordFilter);
            this.fraPatches.Controls.Add(this.chkMapFix);
            this.fraPatches.Location = new System.Drawing.Point(12, 220);
            this.fraPatches.Name = "fraPatches";
            this.fraPatches.Size = new System.Drawing.Size(241, 136);
            this.fraPatches.TabIndex = 17;
            this.fraPatches.TabStop = false;
            this.fraPatches.Text = "Run-time Patches";
            // 
            // chkVista
            // 
            this.chkVista.AutoSize = true;
            this.chkVista.Checked = global::PsoWindowSize.Properties.Settings.Default.KeyboardFix;
            this.chkVista.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVista.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PsoWindowSize.Properties.Settings.Default, "KeyboardFix", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkVista.Location = new System.Drawing.Point(9, 19);
            this.chkVista.Name = "chkVista";
            this.chkVista.Size = new System.Drawing.Size(216, 17);
            this.chkVista.TabIndex = 15;
            this.chkVista.Text = "Keyboard fix for Windows Vista or newer";
            this.chkVista.UseVisualStyleBackColor = true;
            this.chkVista.CheckStateChanged += new System.EventHandler(this.chkVista_CheckStateChanged);
            // 
            // chkWhiteNames
            // 
            this.chkWhiteNames.AutoSize = true;
            this.chkWhiteNames.Checked = global::PsoWindowSize.Properties.Settings.Default.NameFix;
            this.chkWhiteNames.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PsoWindowSize.Properties.Settings.Default, "NameFix", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWhiteNames.Location = new System.Drawing.Point(9, 42);
            this.chkWhiteNames.Name = "chkWhiteNames";
            this.chkWhiteNames.Size = new System.Drawing.Size(175, 17);
            this.chkWhiteNames.TabIndex = 16;
            this.chkWhiteNames.Text = "PSO v1 and GC names in white";
            this.chkWhiteNames.UseVisualStyleBackColor = true;
            this.chkWhiteNames.CheckStateChanged += new System.EventHandler(this.chkWhiteNames_CheckStateChanged);
            // 
            // chkMusicFix
            // 
            this.chkMusicFix.AutoSize = true;
            this.chkMusicFix.Checked = global::PsoWindowSize.Properties.Settings.Default.MusicFix;
            this.chkMusicFix.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PsoWindowSize.Properties.Settings.Default, "MusicFix", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkMusicFix.Location = new System.Drawing.Point(9, 66);
            this.chkMusicFix.Name = "chkMusicFix";
            this.chkMusicFix.Size = new System.Drawing.Size(162, 17);
            this.chkMusicFix.TabIndex = 17;
            this.chkMusicFix.Text = "Battle music in normal quests";
            this.chkMusicFix.UseVisualStyleBackColor = true;
            this.chkMusicFix.CheckStateChanged += new System.EventHandler(this.chkMusicFix_CheckStateChanged);
            // 
            // chkWordFilter
            // 
            this.chkWordFilter.AutoSize = true;
            this.chkWordFilter.Checked = global::PsoWindowSize.Properties.Settings.Default.WordFilter;
            this.chkWordFilter.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PsoWindowSize.Properties.Settings.Default, "WordFilter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWordFilter.Location = new System.Drawing.Point(9, 113);
            this.chkWordFilter.Name = "chkWordFilter";
            this.chkWordFilter.Size = new System.Drawing.Size(109, 17);
            this.chkWordFilter.TabIndex = 19;
            this.chkWordFilter.Text = "Disable word filter";
            this.chkWordFilter.UseVisualStyleBackColor = true;
            this.chkWordFilter.CheckStateChanged += new System.EventHandler(this.chkWordFilter_CheckStateChanged);
            // 
            // chkMapFix
            // 
            this.chkMapFix.AutoSize = true;
            this.chkMapFix.Checked = global::PsoWindowSize.Properties.Settings.Default.MapFix;
            this.chkMapFix.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PsoWindowSize.Properties.Settings.Default, "MapFix", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkMapFix.Location = new System.Drawing.Point(9, 90);
            this.chkMapFix.Name = "chkMapFix";
            this.chkMapFix.Size = new System.Drawing.Size(129, 17);
            this.chkMapFix.TabIndex = 18;
            this.chkMapFix.Text = "Ultimate mode map fix";
            this.chkMapFix.UseVisualStyleBackColor = true;
            this.chkMapFix.CheckStateChanged += new System.EventHandler(this.chkMapFix_CheckStateChanged);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(292, 280);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 20;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // chkWindowed
            // 
            this.chkWindowed.AutoSize = true;
            this.chkWindowed.Checked = global::PsoWindowSize.Properties.Settings.Default.Windowed;
            this.chkWindowed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWindowed.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PsoWindowSize.Properties.Settings.Default, "Windowed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWindowed.Location = new System.Drawing.Point(160, 11);
            this.chkWindowed.Name = "chkWindowed";
            this.chkWindowed.Size = new System.Drawing.Size(77, 17);
            this.chkWindowed.TabIndex = 3;
            this.chkWindowed.Text = "Windowed";
            this.chkWindowed.UseVisualStyleBackColor = true;
            this.chkWindowed.CheckedChanged += new System.EventHandler(this.chkWindowed_CheckedChanged);
            this.chkWindowed.CheckStateChanged += new System.EventHandler(this.chkWindowed_CheckStateChanged);
            // 
            // frmResizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 378);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.fraPatches);
            this.Controls.Add(this.cmdStartOffline);
            this.Controls.Add(this.cmdStartOnline);
            this.Controls.Add(this.chkWindowed);
            this.Controls.Add(this.lblPsoStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.fraWindowed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResizer";
            this.Text = "PSO Launcher and Aspect Ratio Correct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmResizer_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fraWindowed.ResumeLayout(false);
            this.fraWindowed.PerformLayout();
            this.fraCustom.ResumeLayout(false);
            this.fraCustom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtW)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.fraPatches.ResumeLayout(false);
            this.fraPatches.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdResize;
        private System.Windows.Forms.ComboBox cboRatio;
        private System.Windows.Forms.GroupBox fraWindowed;
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
        private System.Windows.Forms.Button cmdLaunch;
        private System.Windows.Forms.CheckBox chkWindowed;
        private System.Windows.Forms.CheckBox chkVista;
        private System.Windows.Forms.CheckBox chkWhiteNames;
        private System.Windows.Forms.CheckBox chkMusicFix;
        private System.Windows.Forms.CheckBox chkMapFix;
        private System.Windows.Forms.CheckBox chkWordFilter;
        private System.Windows.Forms.Button cmdSerial;
        private System.Windows.Forms.RadioButton rdoOffline;
        private System.Windows.Forms.RadioButton rdoOnline;
        private System.Windows.Forms.GroupBox fraPatches;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.CheckBox chkCenterWindow;
    }
}


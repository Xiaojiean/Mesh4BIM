namespace Mesh4BIMApp
{
    partial class Mesh4BIM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mesh4BIM));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuFileOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOutputFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.toolOutputFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolProcess = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolOpenOutput = new System.Windows.Forms.ToolStripButton();
            this.BrowseFolderOpen = new System.Windows.Forms.FolderBrowserDialog();
            this.BrowseFolderOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.listViewOpen = new System.Windows.Forms.ListView();
            this.txbPathInputFolder = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.txbPathOutput = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgbBarra = new System.Windows.Forms.ProgressBar();
            this.radPTS = new System.Windows.Forms.RadioButton();
            this.radPTX = new System.Windows.Forms.RadioButton();
            this.radCustom = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpenOutput = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbRename = new System.Windows.Forms.CheckBox();
            this.txbTriangles = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbBallRadius = new System.Windows.Forms.TextBox();
            this.lblBallRadius = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbRadius = new System.Windows.Forms.TextBox();
            this.chbDecimation = new System.Windows.Forms.CheckBox();
            this.chbSurface = new System.Windows.Forms.CheckBox();
            this.chbNormals = new System.Windows.Forms.CheckBox();
            this.chbSampling = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnOutputFolder = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpenFolder,
            this.menuFileOutputFolder});
            this.menuFile.Image = ((System.Drawing.Image)(resources.GetObject("menuFile.Image")));
            this.menuFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(38, 22);
            this.menuFile.Text = "File";
            // 
            // menuFileOpenFolder
            // 
            this.menuFileOpenFolder.Image = global::Mesh4BIMApp.Properties.Resources.folder_horizontal_open;
            this.menuFileOpenFolder.Name = "menuFileOpenFolder";
            this.menuFileOpenFolder.Size = new System.Drawing.Size(157, 22);
            this.menuFileOpenFolder.Text = "Open Folder...";
            this.menuFileOpenFolder.Click += new System.EventHandler(this.toolOpenFolder_Click);
            // 
            // menuFileOutputFolder
            // 
            this.menuFileOutputFolder.Image = global::Mesh4BIMApp.Properties.Resources.folder_network_horizontal_open;
            this.menuFileOutputFolder.Name = "menuFileOutputFolder";
            this.menuFileOutputFolder.Size = new System.Drawing.Size(157, 22);
            this.menuFileOutputFolder.Text = "Output Folder...";
            this.menuFileOutputFolder.Click += new System.EventHandler(this.toolOutputFolder_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProcess,
            this.menuOpenOutput});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripDropDownButton1.Text = "Process";
            // 
            // menuProcess
            // 
            this.menuProcess.Image = global::Mesh4BIMApp.Properties.Resources.weather_lightning;
            this.menuProcess.Name = "menuProcess";
            this.menuProcess.Size = new System.Drawing.Size(144, 22);
            this.menuProcess.Text = "Start Process";
            this.menuProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // menuOpenOutput
            // 
            this.menuOpenOutput.Image = global::Mesh4BIMApp.Properties.Resources.folder_horizontal_open;
            this.menuOpenOutput.Name = "menuOpenOutput";
            this.menuOpenOutput.Size = new System.Drawing.Size(144, 22);
            this.menuOpenOutput.Text = "Open Output";
            this.menuOpenOutput.Click += new System.EventHandler(this.toolOpenOutput_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton2.Text = "Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Image = global::Mesh4BIMApp.Properties.Resources.information;
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(175, 22);
            this.menuAbout.Text = "About Mesh4BIM...";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOpenFolder,
            this.toolOutputFolder,
            this.toolStripSeparator1,
            this.toolProcess,
            this.toolStripSeparator2,
            this.toolOpenOutput});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(784, 25);
            this.toolStrip2.TabIndex = 13;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolOpenFolder
            // 
            this.toolOpenFolder.Image = global::Mesh4BIMApp.Properties.Resources.folder_horizontal_open;
            this.toolOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOpenFolder.Name = "toolOpenFolder";
            this.toolOpenFolder.Size = new System.Drawing.Size(56, 22);
            this.toolOpenFolder.Text = "Open";
            this.toolOpenFolder.ToolTipText = "Open a PointCloud Folder";
            this.toolOpenFolder.Click += new System.EventHandler(this.toolOpenFolder_Click);
            // 
            // toolOutputFolder
            // 
            this.toolOutputFolder.Image = global::Mesh4BIMApp.Properties.Resources.folder_network_horizontal_open;
            this.toolOutputFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOutputFolder.Name = "toolOutputFolder";
            this.toolOutputFolder.Size = new System.Drawing.Size(60, 22);
            this.toolOutputFolder.Text = "Export";
            this.toolOutputFolder.ToolTipText = "Select an Output folder";
            this.toolOutputFolder.Click += new System.EventHandler(this.toolOutputFolder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolProcess
            // 
            this.toolProcess.Image = global::Mesh4BIMApp.Properties.Resources.weather_lightning;
            this.toolProcess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolProcess.Name = "toolProcess";
            this.toolProcess.Size = new System.Drawing.Size(67, 22);
            this.toolProcess.Text = "Process";
            this.toolProcess.ToolTipText = "Process the PointCloud folder";
            this.toolProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolOpenOutput
            // 
            this.toolOpenOutput.Image = global::Mesh4BIMApp.Properties.Resources.folder_horizontal_open;
            this.toolOpenOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOpenOutput.Name = "toolOpenOutput";
            this.toolOpenOutput.Size = new System.Drawing.Size(65, 22);
            this.toolOpenOutput.Text = "Output";
            this.toolOpenOutput.Click += new System.EventHandler(this.toolOpenOutput_Click);
            // 
            // listViewOpen
            // 
            this.listViewOpen.GridLines = true;
            this.listViewOpen.Location = new System.Drawing.Point(10, 49);
            this.listViewOpen.Name = "listViewOpen";
            this.listViewOpen.Size = new System.Drawing.Size(584, 128);
            this.listViewOpen.TabIndex = 15;
            this.listViewOpen.UseCompatibleStateImageBehavior = false;
            this.listViewOpen.View = System.Windows.Forms.View.List;
            // 
            // txbPathInputFolder
            // 
            this.txbPathInputFolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbPathInputFolder.Location = new System.Drawing.Point(91, 22);
            this.txbPathInputFolder.Name = "txbPathInputFolder";
            this.txbPathInputFolder.ReadOnly = true;
            this.txbPathInputFolder.Size = new System.Drawing.Size(503, 20);
            this.txbPathInputFolder.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbPathInputFolder);
            this.groupBox1.Controls.Add(this.btnOpenFolder);
            this.groupBox1.Controls.Add(this.listViewOpen);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 183);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT DATASET";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Image = global::Mesh4BIMApp.Properties.Resources.folder_horizontal_open;
            this.btnOpenFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFolder.Location = new System.Drawing.Point(10, 20);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFolder.TabIndex = 18;
            this.btnOpenFolder.Text = "Open ";
            this.btnOpenFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.toolOpenFolder_Click);
            // 
            // txbPathOutput
            // 
            this.txbPathOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbPathOutput.Location = new System.Drawing.Point(103, 273);
            this.txbPathOutput.Name = "txbPathOutput";
            this.txbPathOutput.ReadOnly = true;
            this.txbPathOutput.Size = new System.Drawing.Size(422, 20);
            this.txbPathOutput.TabIndex = 21;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 17);
            this.lblStatus.Text = "toolStripStatusLabel1";
            // 
            // pgbBarra
            // 
            this.pgbBarra.Location = new System.Drawing.Point(104, 501);
            this.pgbBarra.Name = "pgbBarra";
            this.pgbBarra.Size = new System.Drawing.Size(502, 23);
            this.pgbBarra.TabIndex = 24;
            // 
            // radPTS
            // 
            this.radPTS.AutoSize = true;
            this.radPTS.Location = new System.Drawing.Point(10, 21);
            this.radPTS.Name = "radPTS";
            this.radPTS.Size = new System.Drawing.Size(79, 17);
            this.radPTS.TabIndex = 25;
            this.radPTS.TabStop = true;
            this.radPTS.Text = "PTS Preset";
            this.radPTS.UseVisualStyleBackColor = true;
            this.radPTS.CheckedChanged += new System.EventHandler(this.radPTS_CheckedChanged);
            // 
            // radPTX
            // 
            this.radPTX.AutoSize = true;
            this.radPTX.Location = new System.Drawing.Point(10, 44);
            this.radPTX.Name = "radPTX";
            this.radPTX.Size = new System.Drawing.Size(79, 17);
            this.radPTX.TabIndex = 26;
            this.radPTX.TabStop = true;
            this.radPTX.Text = "PTX Preset";
            this.radPTX.UseVisualStyleBackColor = true;
            this.radPTX.CheckedChanged += new System.EventHandler(this.radPTX_CheckedChanged);
            // 
            // radCustom
            // 
            this.radCustom.AutoSize = true;
            this.radCustom.Location = new System.Drawing.Point(10, 68);
            this.radCustom.Name = "radCustom";
            this.radCustom.Size = new System.Drawing.Size(93, 17);
            this.radCustom.TabIndex = 27;
            this.radCustom.TabStop = true;
            this.radCustom.Text = "Custom Preset";
            this.radCustom.UseVisualStyleBackColor = true;
            this.radCustom.CheckedChanged += new System.EventHandler(this.radCustom_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpenOutput);
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 60);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OUTPUT FOLDER";
            // 
            // btnOpenOutput
            // 
            this.btnOpenOutput.Image = global::Mesh4BIMApp.Properties.Resources.folder_horizontal_open;
            this.btnOpenOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenOutput.Location = new System.Drawing.Point(519, 24);
            this.btnOpenOutput.Name = "btnOpenOutput";
            this.btnOpenOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOpenOutput.TabIndex = 0;
            this.btnOpenOutput.Text = "Output";
            this.btnOpenOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenOutput.UseVisualStyleBackColor = true;
            this.btnOpenOutput.Click += new System.EventHandler(this.toolOpenOutput_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbRename);
            this.groupBox3.Controls.Add(this.txbTriangles);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txbBallRadius);
            this.groupBox3.Controls.Add(this.lblBallRadius);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txbRadius);
            this.groupBox3.Controls.Add(this.chbDecimation);
            this.groupBox3.Controls.Add(this.chbSurface);
            this.groupBox3.Controls.Add(this.chbNormals);
            this.groupBox3.Controls.Add(this.chbSampling);
            this.groupBox3.Controls.Add(this.radCustom);
            this.groupBox3.Controls.Add(this.radPTX);
            this.groupBox3.Controls.Add(this.radPTS);
            this.groupBox3.Location = new System.Drawing.Point(12, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 158);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PRESET SETTINGS";
            // 
            // chbRename
            // 
            this.chbRename.AutoSize = true;
            this.chbRename.Location = new System.Drawing.Point(211, 22);
            this.chbRename.Name = "chbRename";
            this.chbRename.Size = new System.Drawing.Size(126, 17);
            this.chbRename.TabIndex = 38;
            this.chbRename.Text = "Rebame PTS to ASC";
            this.chbRename.UseVisualStyleBackColor = true;
            // 
            // txbTriangles
            // 
            this.txbTriangles.Location = new System.Drawing.Point(544, 114);
            this.txbTriangles.Name = "txbTriangles";
            this.txbTriangles.Size = new System.Drawing.Size(50, 20);
            this.txbTriangles.TabIndex = 37;
            this.txbTriangles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbTriangles.TextChanged += new System.EventHandler(this.txbTriangles_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Triangles:";
            // 
            // txbBallRadius
            // 
            this.txbBallRadius.Location = new System.Drawing.Point(544, 89);
            this.txbBallRadius.Name = "txbBallRadius";
            this.txbBallRadius.Size = new System.Drawing.Size(50, 20);
            this.txbBallRadius.TabIndex = 35;
            this.txbBallRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbBallRadius.TextChanged += new System.EventHandler(this.txbBallRadius_TextChanged);
            // 
            // lblBallRadius
            // 
            this.lblBallRadius.AutoSize = true;
            this.lblBallRadius.Location = new System.Drawing.Point(462, 92);
            this.lblBallRadius.Name = "lblBallRadius";
            this.lblBallRadius.Size = new System.Drawing.Size(75, 13);
            this.lblBallRadius.TabIndex = 34;
            this.lblBallRadius.Text = "Ball radius [m]:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Disk radius [m]:";
            // 
            // txbRadius
            // 
            this.txbRadius.Location = new System.Drawing.Point(544, 43);
            this.txbRadius.Name = "txbRadius";
            this.txbRadius.Size = new System.Drawing.Size(50, 20);
            this.txbRadius.TabIndex = 32;
            this.txbRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbRadius.TextChanged += new System.EventHandler(this.txbRadius_TextChanged);
            // 
            // chbDecimation
            // 
            this.chbDecimation.AutoSize = true;
            this.chbDecimation.Location = new System.Drawing.Point(211, 116);
            this.chbDecimation.Name = "chbDecimation";
            this.chbDecimation.Size = new System.Drawing.Size(196, 17);
            this.chbDecimation.TabIndex = 31;
            this.chbDecimation.Text = "Decimation (Quadric Edge Collpase)";
            this.chbDecimation.UseVisualStyleBackColor = true;
            // 
            // chbSurface
            // 
            this.chbSurface.AutoSize = true;
            this.chbSurface.Location = new System.Drawing.Point(211, 93);
            this.chbSurface.Name = "chbSurface";
            this.chbSurface.Size = new System.Drawing.Size(133, 17);
            this.chbSurface.TabIndex = 30;
            this.chbSurface.Text = "Surface reconstruction";
            this.chbSurface.UseVisualStyleBackColor = true;
            // 
            // chbNormals
            // 
            this.chbNormals.AutoSize = true;
            this.chbNormals.Location = new System.Drawing.Point(211, 69);
            this.chbNormals.Name = "chbNormals";
            this.chbNormals.Size = new System.Drawing.Size(107, 17);
            this.chbNormals.TabIndex = 29;
            this.chbNormals.Text = "Compute normals";
            this.chbNormals.UseVisualStyleBackColor = true;
            // 
            // chbSampling
            // 
            this.chbSampling.AutoSize = true;
            this.chbSampling.Location = new System.Drawing.Point(211, 45);
            this.chbSampling.Name = "chbSampling";
            this.chbSampling.Size = new System.Drawing.Size(181, 17);
            this.chbSampling.TabIndex = 28;
            this.chbSampling.Text = "Sampling (Poisson disk sampling)";
            this.chbSampling.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(12, 481);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(600, 53);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PROCESS POINTCLOUDS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Mesh4BIMApp.Properties.Resources.Lateral_Image_125x450;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(618, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 476);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnProcess
            // 
            this.btnProcess.Image = global::Mesh4BIMApp.Properties.Resources.weather_lightning;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.Location = new System.Drawing.Point(22, 501);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 22;
            this.btnProcess.Text = "Process";
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.Image = global::Mesh4BIMApp.Properties.Resources.folder_network_horizontal_open;
            this.btnOutputFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutputFolder.Location = new System.Drawing.Point(22, 271);
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(75, 23);
            this.btnOutputFolder.TabIndex = 20;
            this.btnOutputFolder.Text = "Output ";
            this.btnOutputFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.toolOutputFolder_Click);
            // 
            // Mesh4BIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pgbBarra);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txbPathOutput);
            this.Controls.Add(this.btnOutputFolder);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mesh4BIM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesh4BIM 2.0";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpenFolder;
        private System.Windows.Forms.ToolStripMenuItem menuFileOutputFolder;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolOpenFolder;
        private System.Windows.Forms.FolderBrowserDialog BrowseFolderOpen;
        private System.Windows.Forms.FolderBrowserDialog BrowseFolderOutput;
        private System.Windows.Forms.ListView listViewOpen;
        private System.Windows.Forms.ToolStripButton toolOutputFolder;
        private System.Windows.Forms.TextBox txbPathInputFolder;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOutputFolder;
        private System.Windows.Forms.TextBox txbPathOutput;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem menuProcess;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolProcess;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ProgressBar pgbBarra;
        private System.Windows.Forms.RadioButton radPTS;
        private System.Windows.Forms.RadioButton radPTX;
        private System.Windows.Forms.RadioButton radCustom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chbDecimation;
        private System.Windows.Forms.CheckBox chbSurface;
        private System.Windows.Forms.CheckBox chbNormals;
        private System.Windows.Forms.CheckBox chbSampling;
        private System.Windows.Forms.TextBox txbTriangles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbBallRadius;
        private System.Windows.Forms.Label lblBallRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbRadius;
        private System.Windows.Forms.CheckBox chbRename;
        private System.Windows.Forms.ToolStripButton toolOpenOutput;
        private System.Windows.Forms.ToolStripMenuItem menuOpenOutput;
        private System.Windows.Forms.Button btnOpenOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}


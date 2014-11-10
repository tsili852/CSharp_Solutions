using ThinkFTP.HelpClasses;
namespace ThinkFTP
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.iseriesTabPage = new System.Windows.Forms.TabPage();
            this.btnDeleteInstance = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnSaveNewInstance = new System.Windows.Forms.Button();
            this.cmbInstances = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.file = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rButtonMultipleFiles = new System.Windows.Forms.RadioButton();
            this.rButtonOneFIle = new System.Windows.Forms.RadioButton();
            this.lblWindowsPath = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblISFile = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serverGB = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.otherTabPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aboutTabPage = new System.Windows.Forms.TabPage();
            this.btnManual = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.MFilesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtISFIle = new ThinkFTP.HelpClasses.ValidatingTextBox();
            this.txtLibrary = new ThinkFTP.HelpClasses.ValidatingTextBox();
            this.txtPassword = new ThinkFTP.HelpClasses.ValidatingTextBox();
            this.txtUserName = new ThinkFTP.HelpClasses.ValidatingTextBox();
            this.txtAddress = new ThinkFTP.HelpClasses.ValidatingTextBox();
            this.txtWindowsPath = new ThinkFTP.HelpClasses.ValidatingTextBox();
            this.txtWindowsFile = new ThinkFTP.HelpClasses.ValidatingTextBox();
            this.mainTabControl.SuspendLayout();
            this.iseriesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.serverGB.SuspendLayout();
            this.otherTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.aboutTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.iseriesTabPage);
            this.mainTabControl.Controls.Add(this.otherTabPage);
            this.mainTabControl.Controls.Add(this.aboutTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(3, 2);
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(603, 343);
            this.mainTabControl.TabIndex = 13;
            // 
            // iseriesTabPage
            // 
            this.iseriesTabPage.Controls.Add(this.btnDeleteInstance);
            this.iseriesTabPage.Controls.Add(this.btnSaveChanges);
            this.iseriesTabPage.Controls.Add(this.btnSaveNewInstance);
            this.iseriesTabPage.Controls.Add(this.cmbInstances);
            this.iseriesTabPage.Controls.Add(this.label6);
            this.iseriesTabPage.Controls.Add(this.dataGridView1);
            this.iseriesTabPage.Controls.Add(this.lblStatus);
            this.iseriesTabPage.Controls.Add(this.panel1);
            this.iseriesTabPage.Controls.Add(this.txtISFIle);
            this.iseriesTabPage.Controls.Add(this.txtLibrary);
            this.iseriesTabPage.Controls.Add(this.label5);
            this.iseriesTabPage.Controls.Add(this.btnSelectFile);
            this.iseriesTabPage.Controls.Add(this.btnSelectFolder);
            this.iseriesTabPage.Controls.Add(this.groupBox1);
            this.iseriesTabPage.Controls.Add(this.panelButtons);
            this.iseriesTabPage.Controls.Add(this.lblWindowsPath);
            this.iseriesTabPage.Controls.Add(this.label7);
            this.iseriesTabPage.Controls.Add(this.lblISFile);
            this.iseriesTabPage.Controls.Add(this.label4);
            this.iseriesTabPage.Controls.Add(this.serverGB);
            this.iseriesTabPage.Controls.Add(this.txtWindowsPath);
            this.iseriesTabPage.Controls.Add(this.txtWindowsFile);
            this.iseriesTabPage.Location = new System.Drawing.Point(4, 22);
            this.iseriesTabPage.Name = "iseriesTabPage";
            this.iseriesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.iseriesTabPage.Size = new System.Drawing.Size(595, 317);
            this.iseriesTabPage.TabIndex = 0;
            this.iseriesTabPage.Text = "iSeries";
            this.iseriesTabPage.UseVisualStyleBackColor = true;
            // 
            // btnDeleteInstance
            // 
            this.btnDeleteInstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDeleteInstance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteInstance.Location = new System.Drawing.Point(496, 58);
            this.btnDeleteInstance.Name = "btnDeleteInstance";
            this.btnDeleteInstance.Size = new System.Drawing.Size(80, 25);
            this.btnDeleteInstance.TabIndex = 106;
            this.btnDeleteInstance.Text = "Delete";
            this.btnDeleteInstance.UseVisualStyleBackColor = true;
            this.btnDeleteInstance.Click += new System.EventHandler(this.btnDeleteInstance_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChanges.Location = new System.Drawing.Point(410, 58);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(80, 25);
            this.btnSaveChanges.TabIndex = 105;
            this.btnSaveChanges.Text = "Update Inst.";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnSaveNewInstance
            // 
            this.btnSaveNewInstance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveNewInstance.Location = new System.Drawing.Point(324, 58);
            this.btnSaveNewInstance.Name = "btnSaveNewInstance";
            this.btnSaveNewInstance.Size = new System.Drawing.Size(80, 25);
            this.btnSaveNewInstance.TabIndex = 103;
            this.btnSaveNewInstance.Text = "Save New";
            this.btnSaveNewInstance.UseVisualStyleBackColor = true;
            this.btnSaveNewInstance.Click += new System.EventHandler(this.btnSaveInstance_Click);
            // 
            // cmbInstances
            // 
            this.cmbInstances.BackColor = System.Drawing.Color.SeaShell;
            this.cmbInstances.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstances.FormattingEnabled = true;
            this.cmbInstances.Location = new System.Drawing.Point(384, 29);
            this.cmbInstances.Name = "cmbInstances";
            this.cmbInstances.Size = new System.Drawing.Size(192, 21);
            this.cmbInstances.TabIndex = 104;
            this.cmbInstances.TabStop = false;
            this.cmbInstances.SelectedIndexChanged += new System.EventHandler(this.cmbInstances_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(321, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 102;
            this.label6.Text = "Instance";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operation,
            this.file});
            this.dataGridView1.Location = new System.Drawing.Point(410, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(175, 89);
            this.dataGridView1.TabIndex = 20;
            // 
            // operation
            // 
            this.operation.HeaderText = "Operation";
            this.operation.Name = "operation";
            this.operation.ReadOnly = true;
            // 
            // file
            // 
            this.file.HeaderText = "File";
            this.file.Name = "file";
            this.file.ReadOnly = true;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(15, 296);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(582, 15);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClearAll);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(324, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 53);
            this.panel1.TabIndex = 18;
            // 
            // btnClearAll
            // 
            this.btnClearAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearAll.Location = new System.Drawing.Point(11, 13);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(73, 25);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(170, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(73, 25);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Linen;
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.btnDownload);
            this.panelButtons.Controls.Add(this.btnUpload);
            this.panelButtons.Location = new System.Drawing.Point(18, 240);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(261, 53);
            this.panelButtons.TabIndex = 7;
            // 
            // btnDownload
            // 
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownload.Location = new System.Drawing.Point(147, 13);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(103, 25);
            this.btnDownload.TabIndex = 9;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.Location = new System.Drawing.Point(12, 13);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(99, 25);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(407, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Transferred Files";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectFile.Image")));
            this.btnSelectFile.Location = new System.Drawing.Point(366, 201);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(28, 23);
            this.btnSelectFile.TabIndex = 14;
            this.btnSelectFile.TabStop = false;
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectFolder.Image")));
            this.btnSelectFolder.Location = new System.Drawing.Point(366, 171);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(28, 23);
            this.btnSelectFolder.TabIndex = 13;
            this.btnSelectFolder.TabStop = false;
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rButtonMultipleFiles);
            this.groupBox1.Controls.Add(this.rButtonOneFIle);
            this.groupBox1.Location = new System.Drawing.Point(9, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 66);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download Mode";
            // 
            // rButtonMultipleFiles
            // 
            this.rButtonMultipleFiles.AutoSize = true;
            this.rButtonMultipleFiles.Location = new System.Drawing.Point(9, 41);
            this.rButtonMultipleFiles.Name = "rButtonMultipleFiles";
            this.rButtonMultipleFiles.Size = new System.Drawing.Size(85, 17);
            this.rButtonMultipleFiles.TabIndex = 22;
            this.rButtonMultipleFiles.Text = "Multiple Files";
            this.rButtonMultipleFiles.UseVisualStyleBackColor = true;
            this.rButtonMultipleFiles.CheckedChanged += new System.EventHandler(this.rButtonMultipleFiles_CheckedChanged);
            this.rButtonMultipleFiles.MouseHover += new System.EventHandler(this.rButtonMultipleFiles_MouseHover);
            // 
            // rButtonOneFIle
            // 
            this.rButtonOneFIle.AutoSize = true;
            this.rButtonOneFIle.Location = new System.Drawing.Point(9, 18);
            this.rButtonOneFIle.Name = "rButtonOneFIle";
            this.rButtonOneFIle.Size = new System.Drawing.Size(64, 17);
            this.rButtonOneFIle.TabIndex = 21;
            this.rButtonOneFIle.Text = "One File";
            this.rButtonOneFIle.UseVisualStyleBackColor = true;
            this.rButtonOneFIle.CheckedChanged += new System.EventHandler(this.rButtonOneFIle_CheckedChanged);
            // 
            // lblWindowsPath
            // 
            this.lblWindowsPath.Location = new System.Drawing.Point(154, 206);
            this.lblWindowsPath.Name = "lblWindowsPath";
            this.lblWindowsPath.Size = new System.Drawing.Size(79, 17);
            this.lblWindowsPath.TabIndex = 7;
            this.lblWindowsPath.Text = "Windows File";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(154, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Windows Path";
            // 
            // lblISFile
            // 
            this.lblISFile.Location = new System.Drawing.Point(154, 146);
            this.lblISFile.Name = "lblISFile";
            this.lblISFile.Size = new System.Drawing.Size(79, 17);
            this.lblISFile.TabIndex = 3;
            this.lblISFile.Text = "iSeries File";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(154, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "iSeries Library";
            // 
            // serverGB
            // 
            this.serverGB.Controls.Add(this.txtPassword);
            this.serverGB.Controls.Add(this.txtUserName);
            this.serverGB.Controls.Add(this.txtAddress);
            this.serverGB.Controls.Add(this.label3);
            this.serverGB.Controls.Add(this.label2);
            this.serverGB.Controls.Add(this.label1);
            this.serverGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.serverGB.Location = new System.Drawing.Point(9, 4);
            this.serverGB.Name = "serverGB";
            this.serverGB.Size = new System.Drawing.Size(279, 104);
            this.serverGB.TabIndex = 0;
            this.serverGB.TabStop = false;
            this.serverGB.Text = "Server Information";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address";
            // 
            // otherTabPage
            // 
            this.otherTabPage.Controls.Add(this.pictureBox1);
            this.otherTabPage.Location = new System.Drawing.Point(4, 22);
            this.otherTabPage.Name = "otherTabPage";
            this.otherTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.otherTabPage.Size = new System.Drawing.Size(595, 317);
            this.otherTabPage.TabIndex = 1;
            this.otherTabPage.Text = "Other Server";
            this.otherTabPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 290);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // aboutTabPage
            // 
            this.aboutTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.aboutTabPage.Controls.Add(this.btnManual);
            this.aboutTabPage.Controls.Add(this.textBoxDescription);
            this.aboutTabPage.Controls.Add(this.label13);
            this.aboutTabPage.Controls.Add(this.labelCompanyName);
            this.aboutTabPage.Controls.Add(this.label12);
            this.aboutTabPage.Controls.Add(this.labelCopyright);
            this.aboutTabPage.Controls.Add(this.label11);
            this.aboutTabPage.Controls.Add(this.labelVersion);
            this.aboutTabPage.Controls.Add(this.label10);
            this.aboutTabPage.Controls.Add(this.labelProductName);
            this.aboutTabPage.Controls.Add(this.label8);
            this.aboutTabPage.Controls.Add(this.pictureBox2);
            this.aboutTabPage.Location = new System.Drawing.Point(4, 22);
            this.aboutTabPage.Name = "aboutTabPage";
            this.aboutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTabPage.Size = new System.Drawing.Size(595, 317);
            this.aboutTabPage.TabIndex = 2;
            this.aboutTabPage.Text = "About";
            // 
            // btnManual
            // 
            this.btnManual.Enabled = false;
            this.btnManual.Location = new System.Drawing.Point(21, 240);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(75, 50);
            this.btnManual.TabIndex = 11;
            this.btnManual.Text = "Read the Manual";
            this.btnManual.UseVisualStyleBackColor = true;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(124, 208);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(396, 82);
            this.textBoxDescription.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(18, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 18);
            this.label13.TabIndex = 9;
            this.label13.Text = "Description";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCompanyName.Location = new System.Drawing.Point(124, 179);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(396, 18);
            this.labelCompanyName.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(18, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 18);
            this.label12.TabIndex = 7;
            this.label12.Text = "Company";
            // 
            // labelCopyright
            // 
            this.labelCopyright.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCopyright.Location = new System.Drawing.Point(124, 149);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(396, 18);
            this.labelCopyright.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(18, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 18);
            this.label11.TabIndex = 5;
            this.label11.Text = "Copyright";
            // 
            // labelVersion
            // 
            this.labelVersion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelVersion.Location = new System.Drawing.Point(124, 117);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(396, 18);
            this.labelVersion.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(18, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Version";
            // 
            // labelProductName
            // 
            this.labelProductName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelProductName.Location = new System.Drawing.Point(124, 85);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(396, 18);
            this.labelProductName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(18, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Product Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(84, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(436, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // errorProv
            // 
            this.errorProv.BlinkRate = 200;
            this.errorProv.ContainerControl = this;
            this.errorProv.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProv.Icon")));
            // 
            // MFilesToolTip
            // 
            this.MFilesToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.MFilesToolTip.ToolTipTitle = "Not Useable Yet";
            // 
            // txtISFIle
            // 
            this.txtISFIle.ControlToValidate = null;
            this.txtISFIle.Location = new System.Drawing.Point(239, 143);
            this.txtISFIle.Name = "txtISFIle";
            this.txtISFIle.Size = new System.Drawing.Size(155, 20);
            this.txtISFIle.TabIndex = 4;
            this.txtISFIle.TextChanged += new System.EventHandler(this.txtISFIle_Validated);
            this.txtISFIle.Validated += new System.EventHandler(this.txtISFIle_Validated);
            // 
            // txtLibrary
            // 
            this.txtLibrary.ControlToValidate = this.panelButtons;
            this.txtLibrary.Location = new System.Drawing.Point(239, 114);
            this.txtLibrary.Name = "txtLibrary";
            this.txtLibrary.Size = new System.Drawing.Size(155, 20);
            this.txtLibrary.TabIndex = 3;
            this.txtLibrary.TextChanged += new System.EventHandler(this.txtLibrary_Validated);
            this.txtLibrary.Validated += new System.EventHandler(this.txtLibrary_Validated);
            // 
            // txtPassword
            // 
            this.txtPassword.ControlToValidate = this.panelButtons;
            this.txtPassword.Location = new System.Drawing.Point(100, 74);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(155, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_Validated);
            this.txtPassword.Validated += new System.EventHandler(this.txtPassword_Validated);
            // 
            // txtUserName
            // 
            this.txtUserName.ControlToValidate = this.panelButtons;
            this.txtUserName.Location = new System.Drawing.Point(100, 48);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(155, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_Validated);
            this.txtUserName.Validated += new System.EventHandler(this.txtUserName_Validated);
            // 
            // txtAddress
            // 
            this.txtAddress.ControlToValidate = this.panelButtons;
            this.txtAddress.Location = new System.Drawing.Point(100, 22);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(155, 20);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_Validated);
            this.txtAddress.Validated += new System.EventHandler(this.txtAddress_Validated);
            // 
            // txtWindowsPath
            // 
            this.txtWindowsPath.ControlToValidate = this.panelButtons;
            this.txtWindowsPath.Location = new System.Drawing.Point(239, 173);
            this.txtWindowsPath.Name = "txtWindowsPath";
            this.txtWindowsPath.Size = new System.Drawing.Size(155, 20);
            this.txtWindowsPath.TabIndex = 5;
            this.txtWindowsPath.TextChanged += new System.EventHandler(this.txtWindowsPath_Validated);
            this.txtWindowsPath.Validated += new System.EventHandler(this.txtWindowsPath_Validated);
            // 
            // txtWindowsFile
            // 
            this.txtWindowsFile.ControlToValidate = null;
            this.txtWindowsFile.Location = new System.Drawing.Point(239, 203);
            this.txtWindowsFile.Name = "txtWindowsFile";
            this.txtWindowsFile.Size = new System.Drawing.Size(155, 20);
            this.txtWindowsFile.TabIndex = 6;
            this.txtWindowsFile.TextChanged += new System.EventHandler(this.txtWindowsFile_Validated);
            this.txtWindowsFile.Validated += new System.EventHandler(this.txtWindowsFile_Validated);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 345);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(625, 384);
            this.MinimumSize = new System.Drawing.Size(625, 384);
            this.Name = "frmMain";
            this.Text = "Think FTP";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainTabControl.ResumeLayout(false);
            this.iseriesTabPage.ResumeLayout(false);
            this.iseriesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.serverGB.ResumeLayout(false);
            this.serverGB.PerformLayout();
            this.otherTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.aboutTabPage.ResumeLayout(false);
            this.aboutTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage iseriesTabPage;
        private System.Windows.Forms.TabPage otherTabPage;
        private System.Windows.Forms.GroupBox serverGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblISFile;
        private System.Windows.Forms.Label lblWindowsPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rButtonOneFIle;
        private System.Windows.Forms.RadioButton rButtonMultipleFiles;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label5;
        private ValidatingTextBox txtAddress;
        private ValidatingTextBox txtUserName;
        private ValidatingTextBox txtPassword;
        private ValidatingTextBox txtISFIle;
        private ValidatingTextBox txtLibrary;
        private ValidatingTextBox txtWindowsPath;
        private ValidatingTextBox txtWindowsFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn file;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage aboutTabPage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.ToolTip MFilesToolTip;
        private System.Windows.Forms.Button btnDeleteInstance;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnSaveNewInstance;
        private System.Windows.Forms.ComboBox cmbInstances;
        private System.Windows.Forms.Label label6;
    }
}


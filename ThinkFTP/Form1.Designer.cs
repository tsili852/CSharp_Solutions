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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.iseriesTabPage = new System.Windows.Forms.TabPage();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.listBoxTranFiles = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rButtonMultipleFiles = new System.Windows.Forms.RadioButton();
            this.rButtonOneFIle = new System.Windows.Forms.RadioButton();
            this.lblWindowsPath = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblISFile = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serverGB = new System.Windows.Forms.GroupBox();
            this.cmbInstances = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.otherTabPage = new System.Windows.Forms.TabPage();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSaveInstance = new System.Windows.Forms.Button();
            this.txtISFIle = new ThinkFTP.HelpClasses.ValidatingTextBox();
            this.txtLibrary = new ThinkFTP.HelpClasses.ValidatingTextBox();
            this.txtPassword = new ThinkFTP.HelpClasses.ValidatingTextBox();
            this.txtUserName = new ThinkFTP.HelpClasses.ValidatingTextBox();
            this.txtAddress = new ThinkFTP.HelpClasses.ValidatingTextBox();
            this.txtWindowsPath = new ThinkFTP.HelpClasses.ValidatingTextBox();
            this.txtWindowsFile = new ThinkFTP.HelpClasses.ValidatingTextBox();
            this.tabControl1.SuspendLayout();
            this.iseriesTabPage.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.serverGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.iseriesTabPage);
            this.tabControl1.Controls.Add(this.otherTabPage);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 350);
            this.tabControl1.TabIndex = 13;
            // 
            // iseriesTabPage
            // 
            this.iseriesTabPage.Controls.Add(this.panel1);
            this.iseriesTabPage.Controls.Add(this.txtISFIle);
            this.iseriesTabPage.Controls.Add(this.txtLibrary);
            this.iseriesTabPage.Controls.Add(this.listBoxTranFiles);
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
            this.iseriesTabPage.Size = new System.Drawing.Size(583, 324);
            this.iseriesTabPage.TabIndex = 0;
            this.iseriesTabPage.Text = "iSeries";
            this.iseriesTabPage.UseVisualStyleBackColor = true;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Honeydew;
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.btnDownload);
            this.panelButtons.Controls.Add(this.btnUpload);
            this.panelButtons.Location = new System.Drawing.Point(18, 242);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(261, 53);
            this.panelButtons.TabIndex = 7;
            // 
            // btnDownload
            // 
            this.btnDownload.Image = global::ThinkFTP.Properties.Resources.download16;
            this.btnDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownload.Location = new System.Drawing.Point(147, 13);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(103, 25);
            this.btnDownload.TabIndex = 9;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
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
            // listBoxTranFiles
            // 
            this.listBoxTranFiles.FormattingEnabled = true;
            this.listBoxTranFiles.Location = new System.Drawing.Point(413, 116);
            this.listBoxTranFiles.Name = "listBoxTranFiles";
            this.listBoxTranFiles.Size = new System.Drawing.Size(141, 95);
            this.listBoxTranFiles.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(439, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Transferred Files";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Image = global::ThinkFTP.Properties.Resources.selectFile16;
            this.btnSelectFile.Location = new System.Drawing.Point(366, 183);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(28, 23);
            this.btnSelectFile.TabIndex = 14;
            this.btnSelectFile.TabStop = false;
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Image = global::ThinkFTP.Properties.Resources.selectFolder16;
            this.btnSelectFolder.Location = new System.Drawing.Point(366, 153);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(28, 23);
            this.btnSelectFolder.TabIndex = 13;
            this.btnSelectFolder.TabStop = false;
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rButtonMultipleFiles);
            this.groupBox1.Controls.Add(this.rButtonOneFIle);
            this.groupBox1.Location = new System.Drawing.Point(9, 98);
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
            this.lblWindowsPath.Location = new System.Drawing.Point(154, 188);
            this.lblWindowsPath.Name = "lblWindowsPath";
            this.lblWindowsPath.Size = new System.Drawing.Size(79, 17);
            this.lblWindowsPath.TabIndex = 7;
            this.lblWindowsPath.Text = "Windows File";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(154, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Windows Path";
            // 
            // lblISFile
            // 
            this.lblISFile.Location = new System.Drawing.Point(154, 128);
            this.lblISFile.Name = "lblISFile";
            this.lblISFile.Size = new System.Drawing.Size(79, 17);
            this.lblISFile.TabIndex = 3;
            this.lblISFile.Text = "iSeries File";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(154, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "iSeries Library";
            // 
            // serverGB
            // 
            this.serverGB.Controls.Add(this.btnSaveInstance);
            this.serverGB.Controls.Add(this.cmbInstances);
            this.serverGB.Controls.Add(this.label6);
            this.serverGB.Controls.Add(this.txtPassword);
            this.serverGB.Controls.Add(this.txtUserName);
            this.serverGB.Controls.Add(this.txtAddress);
            this.serverGB.Controls.Add(this.label3);
            this.serverGB.Controls.Add(this.label2);
            this.serverGB.Controls.Add(this.label1);
            this.serverGB.Location = new System.Drawing.Point(9, 6);
            this.serverGB.Name = "serverGB";
            this.serverGB.Size = new System.Drawing.Size(568, 82);
            this.serverGB.TabIndex = 0;
            this.serverGB.TabStop = false;
            this.serverGB.Text = "Server Information";
            // 
            // cmbInstances
            // 
            this.cmbInstances.BackColor = System.Drawing.Color.SeaShell;
            this.cmbInstances.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstances.FormattingEnabled = true;
            this.cmbInstances.Location = new System.Drawing.Point(340, 23);
            this.cmbInstances.Name = "cmbInstances";
            this.cmbInstances.Size = new System.Drawing.Size(155, 21);
            this.cmbInstances.TabIndex = 99;
            this.cmbInstances.TabStop = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(277, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Instance";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(277, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address";
            // 
            // otherTabPage
            // 
            this.otherTabPage.Location = new System.Drawing.Point(4, 22);
            this.otherTabPage.Name = "otherTabPage";
            this.otherTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.otherTabPage.Size = new System.Drawing.Size(583, 324);
            this.otherTabPage.TabIndex = 1;
            this.otherTabPage.Text = "Other Server";
            this.otherTabPage.UseVisualStyleBackColor = true;
            // 
            // errorProv
            // 
            this.errorProv.BlinkRate = 200;
            this.errorProv.ContainerControl = this;
            this.errorProv.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProv.Icon")));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClearAll);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(302, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 53);
            this.panel1.TabIndex = 18;
            // 
            // btnClearAll
            // 
            this.btnClearAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearAll.Location = new System.Drawing.Point(12, 13);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(73, 25);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnSaveInstance
            // 
            this.btnSaveInstance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveInstance.Location = new System.Drawing.Point(501, 23);
            this.btnSaveInstance.Name = "btnSaveInstance";
            this.btnSaveInstance.Size = new System.Drawing.Size(61, 46);
            this.btnSaveInstance.TabIndex = 9;
            this.btnSaveInstance.Text = "Save Instance";
            this.btnSaveInstance.UseVisualStyleBackColor = true;
            // 
            // txtISFIle
            // 
            this.txtISFIle.ControlToValidate = null;
            this.txtISFIle.Location = new System.Drawing.Point(239, 125);
            this.txtISFIle.Name = "txtISFIle";
            this.txtISFIle.Size = new System.Drawing.Size(155, 20);
            this.txtISFIle.TabIndex = 4;
            this.txtISFIle.Validated += new System.EventHandler(this.txtISFIle_Validated);
            // 
            // txtLibrary
            // 
            this.txtLibrary.ControlToValidate = this.panelButtons;
            this.txtLibrary.Location = new System.Drawing.Point(239, 96);
            this.txtLibrary.Name = "txtLibrary";
            this.txtLibrary.Size = new System.Drawing.Size(155, 20);
            this.txtLibrary.TabIndex = 3;
            this.txtLibrary.Validated += new System.EventHandler(this.txtLibrary_Validated);
            // 
            // txtPassword
            // 
            this.txtPassword.ControlToValidate = this.panelButtons;
            this.txtPassword.Location = new System.Drawing.Point(340, 49);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(155, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Validated += new System.EventHandler(this.txtPassword_Validated);
            // 
            // txtUserName
            // 
            this.txtUserName.ControlToValidate = this.panelButtons;
            this.txtUserName.Location = new System.Drawing.Point(91, 49);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(155, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Validated += new System.EventHandler(this.txtUserName_Validated);
            // 
            // txtAddress
            // 
            this.txtAddress.ControlToValidate = this.panelButtons;
            this.txtAddress.Location = new System.Drawing.Point(91, 23);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(155, 20);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Validated += new System.EventHandler(this.txtAddress_Validated);
            // 
            // txtWindowsPath
            // 
            this.txtWindowsPath.ControlToValidate = this.panelButtons;
            this.txtWindowsPath.Location = new System.Drawing.Point(239, 155);
            this.txtWindowsPath.Name = "txtWindowsPath";
            this.txtWindowsPath.Size = new System.Drawing.Size(155, 20);
            this.txtWindowsPath.TabIndex = 5;
            this.txtWindowsPath.TextChanged += new System.EventHandler(this.txtWindowsPath_Validated);
            this.txtWindowsPath.Validated += new System.EventHandler(this.txtWindowsPath_Validated);
            // 
            // txtWindowsFile
            // 
            this.txtWindowsFile.ControlToValidate = null;
            this.txtWindowsFile.Location = new System.Drawing.Point(239, 185);
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
            this.ClientSize = new System.Drawing.Size(596, 357);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(612, 396);
            this.MinimumSize = new System.Drawing.Size(612, 396);
            this.Name = "frmMain";
            this.Text = "Think FTP";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.iseriesTabPage.ResumeLayout(false);
            this.iseriesTabPage.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.serverGB.ResumeLayout(false);
            this.serverGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.ListBox listBoxTranFiles;
        private ValidatingTextBox txtAddress;
        private ValidatingTextBox txtUserName;
        private ValidatingTextBox txtPassword;
        private ValidatingTextBox txtISFIle;
        private ValidatingTextBox txtLibrary;
        private ValidatingTextBox txtWindowsPath;
        private ValidatingTextBox txtWindowsFile;
        private System.Windows.Forms.ComboBox cmbInstances;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveInstance;
        private System.Windows.Forms.Button btnClearAll;
    }
}


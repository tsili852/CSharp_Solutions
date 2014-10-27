using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using ThinkFTP.HelpClasses;

namespace ThinkFTP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim().Length == 0)
            {
                errorProv.SetError(txtAddress, "Fill in the server's adress");
            }
            else
            {
                errorProv.SetError(txtAddress, null);
            }
        }

        private void txtUserName_Validated(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Length == 0)
            {
                errorProv.SetError(txtUserName, "Fill in your User Name");
            }
            else
            {
                errorProv.SetError(txtUserName, null);
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim().Length == 0)
            {
                errorProv.SetError(txtPassword, "Fill in the password");
            }
            else
            {
                errorProv.SetError(txtPassword, null);
            }
        }

        private void txtLibrary_Validated(object sender, EventArgs e)
        {
            if (txtLibrary.Text.Trim().Length == 0)
            {
                errorProv.SetError(txtLibrary, "Fill in the iSeries library");
            }
            else
            {
                errorProv.SetError(txtLibrary, null);
            }
        }


        private void txtISFIle_Validated(object sender, EventArgs e)
        {
            if (txtISFIle.Text.Trim().Length == 0 && rButtonMultipleFiles.Checked == false)
            {
                errorProv.SetError(txtISFIle, "Fill in the iSeries object name");
            }
            else
            {
                errorProv.SetError(txtISFIle, null);
            }
        }


        private void txtWindowsPath_Validated(object sender, EventArgs e)
        {
            if (txtWindowsPath.Text.Trim().Length == 0)
            {
                errorProv.SetError(txtWindowsPath, "Fill in a Windows path");
            }
            else
            {
                errorProv.SetError(txtWindowsPath, null);
            }
        }

        private void txtWindowsFile_Validated(object sender, EventArgs e)
        {
            if (txtWindowsFile.Text.Trim().Length == 0 && rButtonMultipleFiles.Checked == false)
            {
                errorProv.SetError(txtWindowsFile, "Fill in the windows file name");
            }
            else
            {
                errorProv.SetError(txtWindowsFile, null);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            rButtonOneFIle.Checked = true;
            panelButtons.Enabled = false;

            Instance inst = new Instance();
            inst.fillFromXML(Properties.Resources.Instances, 1);

            fillFromInstance(inst);
            cmbInstances.Items.Add(inst.Name);
            cmbInstances.SelectedIndex = 0;
        }

        private void rButtonMultipleFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (rButtonMultipleFiles.Checked == true)
            {
                txtISFIle.Enabled = false;
                txtISFIle.Text = "";
                errorProv.SetError(txtISFIle, null);
                txtWindowsFile.Enabled = false;
                txtWindowsFile.Text = "";

                lblISFile.Enabled = false;
                lblWindowsPath.Enabled = false;

                btnSelectFile.Enabled = false;
                
            }
        }

        private void rButtonOneFIle_CheckedChanged(object sender, EventArgs e)
        {
            if (rButtonOneFIle.Checked == true)
            {
                txtISFIle.Enabled = true;
                txtWindowsFile.Enabled = true;

                lblISFile.Enabled = true;
                lblWindowsPath.Enabled = true;

                btnSelectFile.Enabled = true;
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fldBrowser = new FolderBrowserDialog();
            DialogResult folderResult = fldBrowser.ShowDialog();

            if (folderResult == DialogResult.OK)
            {
                txtWindowsPath.Text = fldBrowser.SelectedPath;
                //txtWindowsFile.Text = "";
            }
            
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            openFile.InitialDirectory = txtWindowsPath.Text;
            //openFile.Filter = "*.exe";
            DialogResult fileResult = openFile.ShowDialog();

            if (fileResult == DialogResult.OK)
            {
                txtWindowsFile.Text = openFile.SafeFileName;
                txtWindowsPath.Text = Path.GetDirectoryName(openFile.FileName);

            }
        }

        private void txtISFIle_TextChanged(object sender, EventArgs e)
        {
            txtWindowsFile.Text = txtISFIle.Text;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

        }

        private void fillFromInstance(Instance inst)
        {
            txtAddress.Text = inst.Address;
            txtUserName.Text = inst.UserName;
            txtLibrary.Text = inst.Library;
            txtISFIle.Text = inst.iSeriesFile;
            txtWindowsPath.Text = inst.WindowsPath;
            txtWindowsFile.Text = inst.WindowsFile;
        }










    }
}

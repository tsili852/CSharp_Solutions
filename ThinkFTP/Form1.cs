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
using System.Collections;
using Microsoft.VisualBasic;
using ThinkFTP.HelpClasses;

namespace ThinkFTP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            rButtonOneFIle.Checked = true;
            panelButtons.Enabled = false;

            //string path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            //string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);

            //MessageBox.Show(appPath);

            string dbPath = @"C:\ThinkFTPDatabase";

            if (!File.Exists(dbPath))
            {
                var answer = MessageBox.Show(this, "The database file does not exist. It will be created.", "Database File Error", MessageBoxButtons.OKCancel);
                if (answer == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.Dispose(true);
                }
                else
                {
                    HelpMe.createDatabase(dbPath);
                }
            }

            cmbInstances.Items.Insert(0, "New");

            List<Instance> allInstances = HelpMe.getAllInstances();
            foreach (Instance instance in allInstances)
            {
                cmbInstances.Items.Add(instance.id + ". " + instance.Name);
            }

            cmbInstances.SelectedIndex = 0;

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

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
        }

        private void cmbInstances_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbInstances.SelectedIndex == 0)
            {
                ClearTextBoxes(this);
                panelButtons.Enabled = false;
                txtAddress.Focus();
            }
            else
            {
                Instance selectedInstance = new Instance();

                int id = Convert.ToInt32(cmbInstances.SelectedItem.ToString().Substring(0, 1));

                try
                {
                    selectedInstance.getWithID(id);

                    ClearTextBoxes(this);

                    txtAddress.Text = selectedInstance.Address;
                    txtUserName.Text = selectedInstance.UserName;
                    txtLibrary.Text = selectedInstance.Library;
                    txtISFIle.Text = selectedInstance.iSeriesFile;
                    txtWindowsFile.Text = selectedInstance.WindowsFile;
                    txtWindowsPath.Text = selectedInstance.WindowsPath;
                    if (selectedInstance.Mode == 'S')
                    {
                        rButtonOneFIle.Checked = true;
                    }
                    else
                    {
                        rButtonMultipleFiles.Checked = false;
                    }
                    panelButtons.Enabled = false; ;
                    txtPassword.Focus();

                }
                catch (InstanceNotFoundException)
                {
                    MessageBox.Show("Selected Instance not found","!! Error ", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    cmbInstances.SelectedIndex = 0;
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Uploading.....";
            lblStatus.BackColor = Color.LightSteelBlue;

            string newLibrary = txtLibrary.Text;
            if (!newLibrary.Trim().EndsWith("/"))
            {
                newLibrary = newLibrary + "/";
            }

            string winPath = txtWindowsPath.Text;
            if (!winPath.Trim().EndsWith("\\"))
            {
                winPath = winPath + "\\";
            }

            if (rButtonOneFIle.Checked == true)
            {
                UniFtpService FTPService = new UniFtpService(winPath, txtAddress.Text, txtUserName.Text, txtPassword.Text);

                try
                {

                    panelButtons.Enabled = false;
                    FTPService.uploadFile(txtWindowsFile.Text, newLibrary + txtISFIle.Text);
                    panelButtons.Enabled = true;

                    lblStatus.Text = "File " + txtISFIle.Text + " uploaded !!";
                    lblStatus.BackColor = Color.PaleGreen;

                    dataGridView1.Rows.Add("Upload", txtISFIle.Text);
                }
                catch (Exception ex)
                {
                    lblStatus.BackColor = Color.LightCoral;
                    lblStatus.Text = "Error on upload: " + ex.Message;
                    //MessageBox.Show(this, "Message : " + ex.Message, " !! Error on upload !! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Downloading.....";
            lblStatus.BackColor = Color.LightSteelBlue;
            
            string newLibrary = txtLibrary.Text;
            if (!newLibrary.Trim().EndsWith("/"))
            {
                newLibrary = newLibrary + "/";
            }

            string winPath = txtWindowsPath.Text;
            if (!winPath.Trim().EndsWith("\\"))
            {
                winPath = winPath + "\\";
            }

            if (rButtonOneFIle.Checked == true)
            {
                UniFtpService FTPService = new UniFtpService(winPath, txtAddress.Text, txtUserName.Text, txtPassword.Text);

                try
                {
                    panelButtons.Enabled = false;
                    FTPService.downloadFile(txtWindowsFile.Text, newLibrary + txtISFIle.Text);

                    panelButtons.Enabled = true;
                    lblStatus.Text = "File " + txtISFIle.Text + " downloaded !!";
                    lblStatus.BackColor = Color.PaleGreen;

                    dataGridView1.Rows.Add("Download", txtISFIle.Text);
                }
                catch (Exception ex)
                {
                    lblStatus.BackColor = Color.LightCoral;
                    lblStatus.Text = "Error on download: " + ex.Message;
                    //MessageBox.Show(this, "Message : " + ex.Message, " !! Error on download !! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } 
        }

        private void btnSaveInstance_Click(object sender, EventArgs e)
        {
            if (cmbInstances.SelectedItem.ToString().Trim() == "New")
            {
                string newName = Microsoft.VisualBasic.Interaction.InputBox("Give your instance a name :", "New Instance", "");
                Instance toBeSaved = fillInstanceFromForm(HelpMe.getMaxID(), newName);
            }
            else
            {
                string instName = cmbInstances.SelectedItem.ToString().Trim();
                int id = Convert.ToInt32(instName.Substring(0, 1));

                Instance toBeModified = fillInstanceFromForm(id, "");

                try
                {
                    HelpMe.modifyInstance(toBeModified);

                    lblStatus.Text = "Instance " 
                        + cmbInstances.SelectedItem.ToString().Trim().Substring(2, cmbInstances.SelectedItem.ToString().Trim().Length -2 )
                        + " modified !!";
                    lblStatus.BackColor = Color.PaleGreen;
                }
                catch (Exception ex)
                {
                    lblStatus.BackColor = Color.LightCoral;
                    lblStatus.Text = "Error on saving new instance: " + ex.Message + ex.InnerException;
                }
                
            }

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

        private void ClearTextBoxes(Control control)
        {
            foreach (Control contr in control.Controls)
            {
                if (contr is TextBox)
                {
                    ((TextBox)contr).Clear();
                    errorProv.SetError(((TextBox)contr), "");
                }

                if (contr is ListBox)
                {
                    ((ListBox)contr).Items.Clear();
                }

                if (contr.HasChildren)
                {
                    ClearTextBoxes(contr);
                }


                if (contr is CheckBox)
                {

                    ((CheckBox)contr).Checked = false;
                }
            }
        }

        private Instance fillInstanceFromForm(int _id, string _name)
        {
            Instance retInstance = new Instance
            {
                id = _id,
                Name = _name,
                Address = txtAddress.Text,
                UserName = txtUserName.Text,
                iSeriesFile = txtISFIle.Text,
                Library = txtLibrary.Text,
                WindowsFile = txtWindowsFile.Text,
                WindowsPath = txtWindowsPath.Text
            };

            if (rButtonOneFIle.Checked == true)
            {
                retInstance.Mode = 'S';
            }
            else
            {
                retInstance.Mode = 'M';
            }

            return retInstance;
        }

        private void ClearAllErrors(Control control)
        {
            foreach (Control contr in control.Controls)
            {
                if (contr is TextBox)
                {
                    errorProv.SetError(((TextBox)contr), "");
                }

                if (contr.HasChildren)
                {
                    ClearTextBoxes(contr);
                }
            }
        }
    }
}

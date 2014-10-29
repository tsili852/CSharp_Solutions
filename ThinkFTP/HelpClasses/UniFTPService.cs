using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinSCP;

// WinSCP .NET Assembly : http://winscp.net/eng/docs/library#csharp

namespace ThinkFTP.HelpClasses
{
    class UniFtpService
    {
        public string windowsPath { get; set; }
        public string serverAddress { get; set; }
        public string userName { get; set; }
        public string password { set; get; }

        public UniFtpService(string windowsPath, string serverAddress, string uName, string pass)
        {
            this.windowsPath = windowsPath;
            this.serverAddress = serverAddress;
            userName = uName;
            password = pass;
        }

        public UniFtpService()
        {

        }

        /// <summary>
        /// Upload file to the target server
        /// </summary>
        /// <param name="windowsFile">PC file name</param>
        /// <param name="serverFile">Server file name</param>
        public bool uploadFile(string windowsFile, string serverFile)
        {
            string ftpPath = "ftp://" + serverAddress + "/" + serverFile;

            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                client.Credentials = new System.Net.NetworkCredential(userName, password);
                try
                {
                    client.UploadFile(ftpPath, "STOR", windowsPath + windowsFile);
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        // Help at : http://winscp.net/eng/docs/library_session_getfiles#example
        public void secureDownload(string windowsFile, string serverFile)
        {
            SessionOptions sessionOptions = new SessionOptions {
                Protocol = Protocol.Sftp,
                HostName = serverAddress,
                UserName = this.userName,
                Password = this.password,
                SshHostKeyFingerprint = "ssh-rsa 2048 xx:xx:x"
            };

        }

        /// <summary>
        /// Download file from the destination server
        /// </summary>
        /// <param name="windowsFile">PC file name</param>
        /// <param name="serverFile">Server file name</param>
        public bool downloadFile(string windowsFile, string serverFile)
        {
            string ftpPath = "ftp://" + serverAddress + "/" + serverFile;

            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                client.Credentials = new System.Net.NetworkCredential(userName, password);
                try
                {
                    client.DownloadFile(ftpPath, windowsPath + windowsFile);

                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}

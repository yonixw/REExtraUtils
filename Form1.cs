using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace REExtraUtils
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rtbLinks_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void btnChangeHost_Click(object sender, EventArgs e)
        {
            var ip = "127.0.0.1";
            if (rbUseTextIP.Checked)
            {
                ip = txtCustomIP.Text;
                var valid = IPAddress.TryParse(ip, out _);
                if (!valid)
                {
                    MessageBox.Show("IP is not valid! Stopping.");
                    return;
                }
            }

            var linux_hostsPath = @"Z:\etc\hosts";
            var hostsPath = @"C:\Windows\System32\drivers\etc\hosts";
            if (File.Exists(linux_hostsPath))
            {
                if (MessageBox.Show("Use the Linux (Wine) hosts path?\n"+linux_hostsPath,"Linux detected",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    hostsPath = linux_hostsPath;
                }
            }


            List<string> originalHostLines = new List<string>();
            try
            {
                // This is the simplest way to read the entire file.
                originalHostLines = 
                    File.ReadAllText(@"C:\Windows\System32\drivers\etc\hosts")
                        .Split(new string[] { "\r\n", "\n", "\r" },StringSplitOptions.None)
                        .ToList();
            } catch (Exception ex)
            {
                MessageBox.Show("Error opening hosts file:\n(Run as admin?)\n" + hostsPath+"\n\n" + ex.ToString());
                return;
            }

            var newDomainsArr = rtbHostDomains.Text.Split(new string[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

            // Remove old domains:
            originalHostLines.RemoveAll(s => s.Contains("# RisingEagle Game"));
            foreach (string newdomain in newDomainsArr)
            {
                originalHostLines.RemoveAll(s => s.Contains(" " + newdomain));
            }

            originalHostLines.Add("# RisingEagle Game");
            foreach (string newdomain in newDomainsArr)
            {
                originalHostLines.Add(
                    String.Format("{0} {1} # RisingEagle Game", ip, newdomain)
                    ); 
            }

            try
            {
                File.WriteAllLines(hostsPath, originalHostLines.ToArray());
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing hosts file:\n(Run as admin?)\n" + hostsPath + "\n\n" + ex.ToString());
                return;
            }

        }

        private void txtREDupSrc_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtREDupSrc_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the file paths as a string array
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                // Set the textbox text to the path of the first file dropped
                (sender as TextBox).Text = files[0];
            }
        }

        private void btnChooseDupExe_Click(object sender, EventArgs e)
        {
            if (dlgChooseDup.ShowDialog() != DialogResult.Cancel && File.Exists(dlgChooseDup.FileName))
            {
                txtREDupSrc.Text = dlgChooseDup.FileName;
            }
        }

        byte[] toAsciiBytes(string s)
        {
            return Encoding.ASCII.GetBytes(s);
        }

        int IndexOfBytes(byte[] source, byte[] searchPattern)
        {
            if (searchPattern == null || searchPattern.Length == 0) return -1;

            if (source == null || source.Length < searchPattern.Length) return -1;

            for (int i = 0; i <= source.Length - searchPattern.Length; i++)
            {
                bool isMatch = true;
                for (int j = 0; j < searchPattern.Length; j++)
                {
                    if (source[i + j] != searchPattern[j])
                    {
                        isMatch = false;
                        break;
                    }
                }
                if (isMatch)
                {
                    return i;
                }
            }

            return -1;
        }

        bool ReplaceFromIndex(byte[] source, int index, byte[] replacePattern)
        {
            if (source == null || source.Length == 0 || index < 0 || index > source.Length) return false;

            Array.Copy(replacePattern, 0, source, index, replacePattern.Length);

            return true;
        }

        private void btnCreateDups_Click(object sender, EventArgs e)
        {
            try
            {
                string DupExePath = txtREDupSrc.Text;
                byte[] fileBytes = File.ReadAllBytes(DupExePath);
                var logBytes = toAsciiBytes(".log");
                var logBytesIndx = IndexOfBytes(fileBytes, logBytes);
                var storageBytes = toAsciiBytes("storage.dat");
                var storageBytesIndx = IndexOfBytes(fileBytes, storageBytes);

                var dupCount = (int)Math.Ceiling(numDups.Value);
                for (int i = 0; i < dupCount; i++)
                {
                    var replaceLog = toAsciiBytes(String.Format(".l{0:00}", i));
                    var replaceStorage = toAsciiBytes(String.Format("storage.d{0:00}", i));

                    ReplaceFromIndex(fileBytes, logBytesIndx, replaceLog);
                    ReplaceFromIndex(fileBytes, storageBytesIndx, replaceStorage);

                    File.WriteAllBytes(DupExePath + String.Format("_DUP{0:00}.exe", i), fileBytes);
                }
                MessageBox.Show("Done!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error creating dup files..\n(Run as admin?)" + "\n\n" + ex.ToString());
                return;
            }
        }

        private void txtCustomIP_TextChanged(object sender, EventArgs e)
        {
            rbUseTextIP.Checked = true;
        }

        private void colorCustomIPTxt()
        {
            if (rbUseTextIP.Checked)
            {
                txtCustomIP.BackColor = Color.LightYellow;
            }
            else
            {
                txtCustomIP.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void rbUseTextIP_CheckedChanged(object sender, EventArgs e)
        {
            colorCustomIPTxt();
        }

        private void rbLocalhostIP_CheckedChanged(object sender, EventArgs e)
        {
            colorCustomIPTxt();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtbCommonCommands.Rtf = rtbCommonCommands.Text;
            rtbAdminCommands.Rtf = rtbAdminCommands.Text;
            rtbTclExample.Rtf = rtbTclExample.Text;
        }

        public static string ReadHtml(string url)
        {
            var error = "";
            var errStack = "";
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.SystemDefault;
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                    string html = client.DownloadString(url);
                    MessageBox.Show("Done!");
                    return html;
                }
            }
            catch (WebException ex)
            {
                // Handle web-specific errors (e.g., 404 Not Found, 500 Internal Server Error)
                error = $"A WebException occurred: {ex.Message}";
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    HttpWebResponse response = (HttpWebResponse)ex.Response;
                    error += $"\nStatus Code : {(int)response.StatusCode} {response.StatusCode}";
                    errStack = ex.StackTrace;
                }
                
            }
            catch (Exception ex)
            {
                error = $"An unexpected error occurred: {ex.Message}";
                errStack = ex.StackTrace;
            }
            error += "\n\n" + errStack;
            MessageBox.Show(error, "Error downloading", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }

        private void rtbLinks_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // https://github.com/yonixw/REExtraUtils/releases/download/v1/links.txt
            var data = ReadHtml("https://github.com/yonixw/REExtraUtils/releases/latest/download/links.txt");
            if (data != null)
            {
                if (data.IndexOf(@"{\") > -1)
                {
                    rtbLinks.Rtf = data;
                }
                else
                {
                    rtbLinks.Text = data;
                }
            }
        }
    }
}

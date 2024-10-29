using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeRanameTool
{
    public partial class FormMain : Form
    {
        private int _replacedFileCount = 0;
        private int _renamedFileCount = 0;
        private int _renamedDirCount = 0;

        public FormMain()
        {
            InitializeComponent();
            Text += $" {GetType().Assembly.GetName().Version.ToString(3)}";
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txbFolder.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void ResetLblMessage()
        {
            _replacedFileCount = 0;
            _renamedFileCount = 0;
            _renamedDirCount = 0;
            lblMessage.Text = "";
            lblMessage.ForeColor = Color.Gray;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ResetLblMessage();

            if (string.IsNullOrEmpty(txbSourceText.Text) || string.IsNullOrEmpty(txbNewText.Text) || string.IsNullOrEmpty(txbFolder.Text))
            {
                lblMessage.Text = "All textboxes are not filled";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            if (!Directory.Exists(txbFolder.Text))
            {
                lblMessage.Text = "Folder not found";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            RunReplaceDir(txbFolder.Text);
            lblMessage.Text = $"Success. Replaced files: {_replacedFileCount}, renamed files: {_renamedFileCount}, renamed dirs: {_renamedDirCount}";
            lblMessage.ForeColor = Color.Green;
        }

        private void RunReplaceDir(string dir)
        {
            
            foreach (string f in Directory.GetFiles(dir))
            {
                if (chbRenameFileContent.Checked)
                {
                    string fileContent = File.ReadAllText(f, Encoding.UTF8);
                    string newFileContent = fileContent.Replace(txbSourceText.Text, txbNewText.Text);

                    if (newFileContent != fileContent)
                    {
                        File.WriteAllText(f, newFileContent, Encoding.UTF8);
                        _replacedFileCount++;
                    }
                }

                if (chbRenameFileNames.Checked)
                {
                    var fileInfo = new FileInfo(f);
                    string newFileName = fileInfo.Name.Replace(txbSourceText.Text, txbNewText.Text);
                    if (newFileName != fileInfo.Name)
                    {
                        File.Move(f, Path.Combine(fileInfo.DirectoryName, newFileName));
                        _renamedFileCount++;
                    }
                }
            }

            foreach (string d in Directory.GetDirectories(dir))
            {
                RunReplaceDir(d);

                if (chbRenameFolderNames.Checked)
                {
                    var dirInfo = new DirectoryInfo(d);
                    string newDirName = dirInfo.Name.Replace(txbSourceText.Text, txbNewText.Text);
                    if (newDirName != dirInfo.Name)
                    {
                        Directory.Move(d, Path.Combine(dirInfo.Parent.FullName, newDirName));
                        _renamedDirCount++;
                    }
                }
            }
        }

        private void txbFolder_TextChanged(object sender, EventArgs e)
        {
            ResetLblMessage();
        }

        private void txbSourceText_TextChanged(object sender, EventArgs e)
        {
            ResetLblMessage();
        }

        private void txbNewText_TextChanged(object sender, EventArgs e)
        {
            ResetLblMessage();
        }
    }
}

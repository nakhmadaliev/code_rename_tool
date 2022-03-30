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
        public FormMain()
        {
            InitializeComponent();
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
            lblMessage.Text = "";
            lblMessage.ForeColor = Color.Gray;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ResetLblMessage();

            if (string.IsNullOrEmpty(txbSourceText.Text) || string.IsNullOrEmpty(txbNewText.Text) || string.IsNullOrEmpty(txbFolder.Text))
            {
                lblMessage.Text = "Not filled any textbox";
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
            lblMessage.Text = "Success";
            lblMessage.ForeColor = Color.Green;
        }

        private void RunReplaceDir(string dir)
        {
            
            foreach (string f in Directory.GetFiles(dir))
            {
                if (chbRenameFileContent.Checked)
                {
                    string fileContent = File.ReadAllText(f);
                    fileContent = fileContent.Replace(txbSourceText.Text, txbNewText.Text);
                    File.WriteAllText(f, fileContent);
                }

                if (chbRenameFileNames.Checked)
                {
                    var fileInfo = new FileInfo(f);
                    string newFileName = fileInfo.Name.Replace(txbSourceText.Text, txbNewText.Text);
                    if (newFileName != fileInfo.Name)
                        File.Move(f, Path.Combine(fileInfo.DirectoryName, newFileName));
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
                        Directory.Move(d, Path.Combine(dirInfo.Parent.FullName, newDirName));
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


namespace CodeRanameTool
{
    partial class FormMain
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txbFolder = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSourceText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNewText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbRenameFileNames = new System.Windows.Forms.CheckBox();
            this.chbRenameFolderNames = new System.Windows.Forms.CheckBox();
            this.chbRenameFileContent = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbFolder
            // 
            this.txbFolder.Location = new System.Drawing.Point(119, 112);
            this.txbFolder.Name = "txbFolder";
            this.txbFolder.Size = new System.Drawing.Size(555, 20);
            this.txbFolder.TabIndex = 0;
            this.txbFolder.TextChanged += new System.EventHandler(this.txbFolder_TextChanged);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(680, 110);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(58, 23);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder";
            // 
            // txbSourceText
            // 
            this.txbSourceText.Location = new System.Drawing.Point(119, 152);
            this.txbSourceText.Name = "txbSourceText";
            this.txbSourceText.Size = new System.Drawing.Size(555, 20);
            this.txbSourceText.TabIndex = 3;
            this.txbSourceText.TextChanged += new System.EventHandler(this.txbSourceText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Source text";
            // 
            // txbNewText
            // 
            this.txbNewText.Location = new System.Drawing.Point(119, 190);
            this.txbNewText.Name = "txbNewText";
            this.txbNewText.Size = new System.Drawing.Size(555, 20);
            this.txbNewText.TabIndex = 5;
            this.txbNewText.TextChanged += new System.EventHandler(this.txbNewText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "New text";
            // 
            // chbRenameFileNames
            // 
            this.chbRenameFileNames.AutoSize = true;
            this.chbRenameFileNames.Checked = true;
            this.chbRenameFileNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbRenameFileNames.Location = new System.Drawing.Point(213, 231);
            this.chbRenameFileNames.Name = "chbRenameFileNames";
            this.chbRenameFileNames.Size = new System.Drawing.Size(116, 17);
            this.chbRenameFileNames.TabIndex = 7;
            this.chbRenameFileNames.Text = "Rename file names";
            this.chbRenameFileNames.UseVisualStyleBackColor = true;
            // 
            // chbRenameFolderNames
            // 
            this.chbRenameFolderNames.AutoSize = true;
            this.chbRenameFolderNames.Checked = true;
            this.chbRenameFolderNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbRenameFolderNames.Location = new System.Drawing.Point(335, 231);
            this.chbRenameFolderNames.Name = "chbRenameFolderNames";
            this.chbRenameFolderNames.Size = new System.Drawing.Size(129, 17);
            this.chbRenameFolderNames.TabIndex = 8;
            this.chbRenameFolderNames.Text = "Rename folder names";
            this.chbRenameFolderNames.UseVisualStyleBackColor = true;
            // 
            // chbRenameFileContent
            // 
            this.chbRenameFileContent.AutoSize = true;
            this.chbRenameFileContent.Checked = true;
            this.chbRenameFileContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbRenameFileContent.Location = new System.Drawing.Point(470, 231);
            this.chbRenameFileContent.Name = "chbRenameFileContent";
            this.chbRenameFileContent.Size = new System.Drawing.Size(121, 17);
            this.chbRenameFileContent.TabIndex = 9;
            this.chbRenameFileContent.Text = "Rename file content";
            this.chbRenameFileContent.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(599, 299);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(369, 304);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chbRenameFileContent);
            this.Controls.Add(this.chbRenameFolderNames);
            this.Controls.Add(this.chbRenameFileNames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNewText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbSourceText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txbFolder);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeRenameTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txbFolder;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSourceText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNewText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbRenameFileNames;
        private System.Windows.Forms.CheckBox chbRenameFolderNames;
        private System.Windows.Forms.CheckBox chbRenameFileContent;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblMessage;
    }
}


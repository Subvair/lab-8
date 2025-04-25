namespace DirectorySyncMVP
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxDir1;
        private System.Windows.Forms.TextBox textBoxDir2;
        private System.Windows.Forms.Button buttonBrowse1;
        private System.Windows.Forms.Button buttonBrowse2;
        private System.Windows.Forms.Button buttonSync;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxDir1 = new System.Windows.Forms.TextBox();
            this.textBoxDir2 = new System.Windows.Forms.TextBox();
            this.buttonBrowse1 = new System.Windows.Forms.Button();
            this.buttonBrowse2 = new System.Windows.Forms.Button();
            this.buttonSync = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textBoxDir1
            // 
            this.textBoxDir1.Location = new System.Drawing.Point(100, 10);
            this.textBoxDir1.Size = new System.Drawing.Size(400, 20);
            // 
            // textBoxDir2
            // 
            this.textBoxDir2.Location = new System.Drawing.Point(100, 40);
            this.textBoxDir2.Size = new System.Drawing.Size(400, 20);
            // 
            // buttonBrowse1
            // 
            this.buttonBrowse1.Location = new System.Drawing.Point(510, 10);
            this.buttonBrowse1.Text = "Обзор...";
            this.buttonBrowse1.Click += new System.EventHandler(this.buttonBrowse1_Click);
            // 
            // buttonBrowse2
            // 
            this.buttonBrowse2.Location = new System.Drawing.Point(510, 40);
            this.buttonBrowse2.Text = "Обзор...";
            this.buttonBrowse2.Click += new System.EventHandler(this.buttonBrowse2_Click);
            // 
            // buttonSync
            // 
            this.buttonSync.Location = new System.Drawing.Point(10, 80);
            this.buttonSync.Size = new System.Drawing.Size(600, 30);
            this.buttonSync.Text = "Синхронизировать";
            this.buttonSync.Click += new System.EventHandler(this.buttonSync_Click);
            // 
            // listBoxLog
            // 
            this.listBoxLog.Location = new System.Drawing.Point(10, 120);
            this.listBoxLog.Size = new System.Drawing.Size(600, 300);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.textBoxDir1);
            this.Controls.Add(this.textBoxDir2);
            this.Controls.Add(this.buttonBrowse1);
            this.Controls.Add(this.buttonBrowse2);
            this.Controls.Add(this.buttonSync);
            this.Controls.Add(this.listBoxLog);
            this.Text = "Синхронизация директорий (MVP)";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
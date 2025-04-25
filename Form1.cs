using System;
using System.Windows.Forms;

namespace DirectorySyncMVP
{
    public partial class Form1 : Form, IView
    {
        public string Directory1Path => textBoxDir1.Text;
        public string Directory2Path => textBoxDir2.Text;
        public event Action SyncRequested;

        public Form1()
        {
            InitializeComponent();
            var presenter = new SyncPresenter(this, new SyncModel());
        }

        private void buttonSync_Click(object sender, EventArgs e) => SyncRequested?.Invoke();

        public void ShowLog(string message) => listBoxLog.Items.Add(message);

        private void buttonBrowse1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                textBoxDir1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void buttonBrowse2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
                textBoxDir2.Text = folderBrowserDialog2.SelectedPath;
        }
    }
}
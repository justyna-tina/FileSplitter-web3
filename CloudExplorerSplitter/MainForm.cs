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

namespace CloudExplorerSplitter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            mainProgressBar.Value = 0;
            mainProgressBar.Value = mainProgressBar.Maximum / 2;

            //get parameters; default n= 2?
            int n = int.Parse(splitNTextBox.Text);
            string filename = splitInputFileTextBox.Text;
            
            //TODO: use base64
            //int encryptionResult = Splitter.Base64File(filename);
            int splitResult = Splitter.Split(filename, n);

            //TODO: generate hash files

            if (splitResult == 0)
            {
                richTextBox1.AppendText("Divided\n");
            }

            mainProgressBar.Value = mainProgressBar.Maximum;
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            mainProgressBar.Value = 0;
            mainProgressBar.Value = mainProgressBar.Maximum / 2;

            //get parameters; default n= 2?
            int n = int.Parse(mergeNTextBox.Text);
            string filename = mergeInputFileTextBox.Text;

            int mergeResult = Splitter.Merge(filename, n);

            if (mergeResult == 0)
            {
                richTextBox1.AppendText("Merged\n");
            }

            mainProgressBar.Value = mainProgressBar.Maximum;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

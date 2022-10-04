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
            string filePath = splitInputFileTextBox.Text;
            string directoryName = splitOutputFileTextBox.Text;

            //TODO: use base64
            //int encryptionResult = Splitter.Base64File(filename);
            int splitResult = Splitter.Split(filePath, n, directoryName);

            //TODO: generate hash files
            //TODO: generate config file

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
            string outputFilePath = mergeOutputFileTextBox.Text;
            string inputDirectoryPath = mergeInputFileTextBox.Text;

            int mergeResult = Splitter.Merge(inputDirectoryPath, n, outputFilePath);

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

        private void inputBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openSplitInputFileDialog = new OpenFileDialog();
            DialogResult result = openSplitInputFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                splitInputFileTextBox.Text = openSplitInputFileDialog.FileName;
            }
            Console.WriteLine(result);
        }

        private void outputBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog splitOutputFolderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = splitOutputFolderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                splitOutputFileTextBox.Text = splitOutputFolderBrowserDialog.SelectedPath;
            }
            Console.WriteLine(result);
        }

        private void inputMergeBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog mergeOutputFolderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = mergeOutputFolderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                mergeInputFileTextBox.Text = mergeOutputFolderBrowserDialog.SelectedPath;
            }
            Console.WriteLine(result);
        }

        private void outputMergeBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openMergeOutputFileDialog = new OpenFileDialog();
            DialogResult result = openMergeOutputFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                mergeOutputFileTextBox.Text = openMergeOutputFileDialog.FileName;
            }
            Console.WriteLine(result);
        }

        private void inputDirBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog inputDirBrowserDialog = new FolderBrowserDialog();
            inputDirBrowserDialog.SelectedPath = Directory.GetCurrentDirectory();
            DialogResult result = inputDirBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                splitInputDirTextBox.Text = inputDirBrowserDialog.SelectedPath;
            }
            Console.WriteLine(result);
        }

        private void disperseButton_Click(object sender, EventArgs e)
        {
            //+create folder
            //+create config file
            //create n folders
            //split every file; version 1: name without number
            //subdirectories??? how do directory name changes? 1 version without changes; 2 version: letters + hash
            
            mainProgressBar.Value = 0;
            mainProgressBar.Value = mainProgressBar.Maximum / 2;

            //get parameters; default n= 2?
            int n = int.Parse(splitDirNTextBox.Text);
            if (n < 2 || n > 4)
            {
                richTextBox1.AppendText("Bad parameter n.\n");
                mainProgressBar.Value = mainProgressBar.Maximum;
                return;
            }
            string dirPath = splitInputDirTextBox.Text;
            List<string> virtualDirectoryNames = new List<string>();
            virtualDirectoryNames.Add(descriptionDir1TextBox.Text);
            virtualDirectoryNames.Add(descriptionDir2TextBox.Text);
            if (n >= 3) { virtualDirectoryNames.Add(descriptionDir3TextBox.Text); }
            if (n >= 4) { virtualDirectoryNames.Add(descriptionDir4TextBox.Text); }
            
            List<string> virtualDirectoryPaths = new List<string>();
            virtualDirectoryPaths.Add(additionalInfoDir1TextBox.Text);
            virtualDirectoryPaths.Add(additionalInfoDir2TextBox.Text);
            if (n >= 3) { virtualDirectoryPaths.Add(additionalInfoDir3TextBox.Text); }
            if (n >= 4) { virtualDirectoryPaths.Add(additionalInfoDir4TextBox.Text); }

            int createConfigFileResult = Disperser.CreateConfigFile(dirPath, n, virtualDirectoryNames, virtualDirectoryPaths);
            //int disperseResult = 0;
            int disperseResult = Disperser.Disperse(dirPath, n, virtualDirectoryNames);
            
            if (disperseResult == 0)
            {
                richTextBox1.AppendText("Dispersed\n");
            }

            mainProgressBar.Value = mainProgressBar.Maximum;
        }

        private void concentrateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under construction");
        }

        private void syncButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under construction");
        }

        private void generateFoldersButton_Click(object sender, EventArgs e)
        {

        }
    }
}

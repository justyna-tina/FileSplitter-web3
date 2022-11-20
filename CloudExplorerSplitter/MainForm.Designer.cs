namespace CloudExplorerSplitter
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitInputFileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitNTextBox = new System.Windows.Forms.TextBox();
            this.mergeButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.outputBrowseButton = new System.Windows.Forms.Button();
            this.inputBrowseButton = new System.Windows.Forms.Button();
            this.splitOutputFileTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.outputMergeBrowseButton = new System.Windows.Forms.Button();
            this.inputMergeBrowseButton = new System.Windows.Forms.Button();
            this.mergeOutputFileTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mergeInputFileTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mergeNTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.additionalInfoDir4TextBox = new System.Windows.Forms.TextBox();
            this.additionalInfoDir3TextBox = new System.Windows.Forms.TextBox();
            this.additionalInfoDir2TextBox = new System.Windows.Forms.TextBox();
            this.additionalInfoDir1TextBox = new System.Windows.Forms.TextBox();
            this.generateFoldersButton = new System.Windows.Forms.Button();
            this.syncButton = new System.Windows.Forms.Button();
            this.concentrateButton = new System.Windows.Forms.Button();
            this.disperseButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.descriptionDir4TextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.descriptionDir3TextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.descriptionDir2TextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.descriptionDir1TextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.inputDirBrowseButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.splitInputDirTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.splitDirNTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.label18 = new System.Windows.Forms.Label();
            this.splitOutputDirTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitInputFileTextBox
            // 
            this.splitInputFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitInputFileTextBox.Location = new System.Drawing.Point(89, 6);
            this.splitInputFileTextBox.Name = "splitInputFileTextBox";
            this.splitInputFileTextBox.Size = new System.Drawing.Size(592, 20);
            this.splitInputFileTextBox.TabIndex = 0;
            this.splitInputFileTextBox.Text = "test.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File to split";
            // 
            // splitButton
            // 
            this.splitButton.Location = new System.Drawing.Point(6, 106);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(75, 23);
            this.splitButton.TabIndex = 2;
            this.splitButton.Text = "Divide";
            this.splitButton.UseVisualStyleBackColor = true;
            this.splitButton.Click += new System.EventHandler(this.splitButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 158);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Divide into";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "files";
            // 
            // splitNTextBox
            // 
            this.splitNTextBox.Location = new System.Drawing.Point(89, 64);
            this.splitNTextBox.Name = "splitNTextBox";
            this.splitNTextBox.Size = new System.Drawing.Size(56, 20);
            this.splitNTextBox.TabIndex = 6;
            this.splitNTextBox.Text = "5";
            // 
            // mergeButton
            // 
            this.mergeButton.Location = new System.Drawing.Point(6, 147);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(75, 23);
            this.mergeButton.TabIndex = 7;
            this.mergeButton.Text = "Merge";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Controls.Add(this.tabPage3);
            this.mainTabControl.Location = new System.Drawing.Point(12, 27);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(776, 284);
            this.mainTabControl.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.outputBrowseButton);
            this.tabPage1.Controls.Add(this.inputBrowseButton);
            this.tabPage1.Controls.Add(this.splitOutputFileTextBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.splitInputFileTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.splitButton);
            this.tabPage1.Controls.Add(this.splitNTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 192);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Split / Divide";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // outputBrowseButton
            // 
            this.outputBrowseButton.Location = new System.Drawing.Point(687, 30);
            this.outputBrowseButton.Name = "outputBrowseButton";
            this.outputBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.outputBrowseButton.TabIndex = 10;
            this.outputBrowseButton.Text = "Browse...";
            this.outputBrowseButton.UseVisualStyleBackColor = true;
            this.outputBrowseButton.Click += new System.EventHandler(this.outputBrowseButton_Click);
            // 
            // inputBrowseButton
            // 
            this.inputBrowseButton.Location = new System.Drawing.Point(687, 4);
            this.inputBrowseButton.Name = "inputBrowseButton";
            this.inputBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.inputBrowseButton.TabIndex = 9;
            this.inputBrowseButton.Text = "Browse...";
            this.inputBrowseButton.UseVisualStyleBackColor = true;
            this.inputBrowseButton.Click += new System.EventHandler(this.inputBrowseButton_Click);
            // 
            // splitOutputFileTextBox
            // 
            this.splitOutputFileTextBox.Location = new System.Drawing.Point(89, 32);
            this.splitOutputFileTextBox.Name = "splitOutputFileTextBox";
            this.splitOutputFileTextBox.Size = new System.Drawing.Size(592, 20);
            this.splitOutputFileTextBox.TabIndex = 8;
            this.splitOutputFileTextBox.Text = ".test.txt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Output directory";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.outputMergeBrowseButton);
            this.tabPage2.Controls.Add(this.inputMergeBrowseButton);
            this.tabPage2.Controls.Add(this.mergeOutputFileTextBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.mergeInputFileTextBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.mergeNTextBox);
            this.tabPage2.Controls.Add(this.mergeButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 192);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Merge / Unite";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Output file should be the same as original filename!";
            // 
            // outputMergeBrowseButton
            // 
            this.outputMergeBrowseButton.Location = new System.Drawing.Point(687, 36);
            this.outputMergeBrowseButton.Name = "outputMergeBrowseButton";
            this.outputMergeBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.outputMergeBrowseButton.TabIndex = 16;
            this.outputMergeBrowseButton.Text = "Browse...";
            this.outputMergeBrowseButton.UseVisualStyleBackColor = true;
            this.outputMergeBrowseButton.Click += new System.EventHandler(this.outputMergeBrowseButton_Click);
            // 
            // inputMergeBrowseButton
            // 
            this.inputMergeBrowseButton.Location = new System.Drawing.Point(687, 10);
            this.inputMergeBrowseButton.Name = "inputMergeBrowseButton";
            this.inputMergeBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.inputMergeBrowseButton.TabIndex = 15;
            this.inputMergeBrowseButton.Text = "Browse...";
            this.inputMergeBrowseButton.UseVisualStyleBackColor = true;
            this.inputMergeBrowseButton.Click += new System.EventHandler(this.inputMergeBrowseButton_Click);
            // 
            // mergeOutputFileTextBox
            // 
            this.mergeOutputFileTextBox.Location = new System.Drawing.Point(89, 38);
            this.mergeOutputFileTextBox.Name = "mergeOutputFileTextBox";
            this.mergeOutputFileTextBox.Size = new System.Drawing.Size(592, 20);
            this.mergeOutputFileTextBox.TabIndex = 14;
            this.mergeOutputFileTextBox.Text = "test.txt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Output file";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Directory to split";
            // 
            // mergeInputFileTextBox
            // 
            this.mergeInputFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mergeInputFileTextBox.Location = new System.Drawing.Point(89, 12);
            this.mergeInputFileTextBox.Name = "mergeInputFileTextBox";
            this.mergeInputFileTextBox.Size = new System.Drawing.Size(592, 20);
            this.mergeInputFileTextBox.TabIndex = 8;
            this.mergeInputFileTextBox.Text = ".test.txt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Divided into";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "files";
            // 
            // mergeNTextBox
            // 
            this.mergeNTextBox.Location = new System.Drawing.Point(69, 77);
            this.mergeNTextBox.Name = "mergeNTextBox";
            this.mergeNTextBox.Size = new System.Drawing.Size(56, 20);
            this.mergeNTextBox.TabIndex = 12;
            this.mergeNTextBox.Text = "5";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitOutputDirTextBox);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.additionalInfoDir4TextBox);
            this.tabPage3.Controls.Add(this.additionalInfoDir3TextBox);
            this.tabPage3.Controls.Add(this.additionalInfoDir2TextBox);
            this.tabPage3.Controls.Add(this.additionalInfoDir1TextBox);
            this.tabPage3.Controls.Add(this.generateFoldersButton);
            this.tabPage3.Controls.Add(this.syncButton);
            this.tabPage3.Controls.Add(this.concentrateButton);
            this.tabPage3.Controls.Add(this.disperseButton);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.descriptionDir4TextBox);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.descriptionDir3TextBox);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.descriptionDir2TextBox);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.descriptionDir1TextBox);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.inputDirBrowseButton);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.splitInputDirTextBox);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.splitDirNTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 258);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cloud Dispersion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // additionalInfoDir4TextBox
            // 
            this.additionalInfoDir4TextBox.Location = new System.Drawing.Point(248, 176);
            this.additionalInfoDir4TextBox.Name = "additionalInfoDir4TextBox";
            this.additionalInfoDir4TextBox.Size = new System.Drawing.Size(430, 20);
            this.additionalInfoDir4TextBox.TabIndex = 32;
            // 
            // additionalInfoDir3TextBox
            // 
            this.additionalInfoDir3TextBox.Location = new System.Drawing.Point(248, 150);
            this.additionalInfoDir3TextBox.Name = "additionalInfoDir3TextBox";
            this.additionalInfoDir3TextBox.Size = new System.Drawing.Size(430, 20);
            this.additionalInfoDir3TextBox.TabIndex = 31;
            this.additionalInfoDir3TextBox.Text = ".\\.test1\\Dropbox; should be path on Dropbox";
            // 
            // additionalInfoDir2TextBox
            // 
            this.additionalInfoDir2TextBox.Location = new System.Drawing.Point(248, 124);
            this.additionalInfoDir2TextBox.Name = "additionalInfoDir2TextBox";
            this.additionalInfoDir2TextBox.Size = new System.Drawing.Size(430, 20);
            this.additionalInfoDir2TextBox.TabIndex = 30;
            this.additionalInfoDir2TextBox.Text = ".\\.test1\\MicrosoftOneDrive; should be path on OneDrive";
            // 
            // additionalInfoDir1TextBox
            // 
            this.additionalInfoDir1TextBox.Location = new System.Drawing.Point(248, 98);
            this.additionalInfoDir1TextBox.Name = "additionalInfoDir1TextBox";
            this.additionalInfoDir1TextBox.Size = new System.Drawing.Size(430, 20);
            this.additionalInfoDir1TextBox.TabIndex = 29;
            this.additionalInfoDir1TextBox.Text = ".\\.test1\\GoogleDrive; should be path on GoogleDrive";
            // 
            // generateFoldersButton
            // 
            this.generateFoldersButton.Location = new System.Drawing.Point(245, 232);
            this.generateFoldersButton.Name = "generateFoldersButton";
            this.generateFoldersButton.Size = new System.Drawing.Size(132, 23);
            this.generateFoldersButton.TabIndex = 28;
            this.generateFoldersButton.Text = "Generate Folders";
            this.generateFoldersButton.UseVisualStyleBackColor = true;
            this.generateFoldersButton.Visible = false;
            this.generateFoldersButton.Click += new System.EventHandler(this.generateFoldersButton_Click);
            // 
            // syncButton
            // 
            this.syncButton.Location = new System.Drawing.Point(164, 232);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(75, 23);
            this.syncButton.TabIndex = 27;
            this.syncButton.Text = "Synchronize";
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Visible = false;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // concentrateButton
            // 
            this.concentrateButton.Location = new System.Drawing.Point(83, 232);
            this.concentrateButton.Name = "concentrateButton";
            this.concentrateButton.Size = new System.Drawing.Size(75, 23);
            this.concentrateButton.TabIndex = 26;
            this.concentrateButton.Text = "Concentrate";
            this.concentrateButton.UseVisualStyleBackColor = true;
            this.concentrateButton.Click += new System.EventHandler(this.concentrateButton_Click);
            // 
            // disperseButton
            // 
            this.disperseButton.Location = new System.Drawing.Point(3, 232);
            this.disperseButton.Name = "disperseButton";
            this.disperseButton.Size = new System.Drawing.Size(75, 23);
            this.disperseButton.TabIndex = 25;
            this.disperseButton.Text = "Disperse";
            this.disperseButton.UseVisualStyleBackColor = true;
            this.disperseButton.Click += new System.EventHandler(this.disperseButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Descritpion:";
            // 
            // descriptionDir4TextBox
            // 
            this.descriptionDir4TextBox.Location = new System.Drawing.Point(86, 176);
            this.descriptionDir4TextBox.Name = "descriptionDir4TextBox";
            this.descriptionDir4TextBox.Size = new System.Drawing.Size(156, 20);
            this.descriptionDir4TextBox.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(67, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "4";
            // 
            // descriptionDir3TextBox
            // 
            this.descriptionDir3TextBox.Location = new System.Drawing.Point(86, 150);
            this.descriptionDir3TextBox.Name = "descriptionDir3TextBox";
            this.descriptionDir3TextBox.Size = new System.Drawing.Size(156, 20);
            this.descriptionDir3TextBox.TabIndex = 21;
            this.descriptionDir3TextBox.Text = "Dropbox";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(67, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "3";
            // 
            // descriptionDir2TextBox
            // 
            this.descriptionDir2TextBox.Location = new System.Drawing.Point(86, 124);
            this.descriptionDir2TextBox.Name = "descriptionDir2TextBox";
            this.descriptionDir2TextBox.Size = new System.Drawing.Size(156, 20);
            this.descriptionDir2TextBox.TabIndex = 19;
            this.descriptionDir2TextBox.Text = "MicrosoftOneDrive";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(67, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "2";
            // 
            // descriptionDir1TextBox
            // 
            this.descriptionDir1TextBox.Location = new System.Drawing.Point(86, 98);
            this.descriptionDir1TextBox.Name = "descriptionDir1TextBox";
            this.descriptionDir1TextBox.Size = new System.Drawing.Size(156, 20);
            this.descriptionDir1TextBox.TabIndex = 17;
            this.descriptionDir1TextBox.Text = "GoogleDrive";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(67, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "1";
            // 
            // inputDirBrowseButton
            // 
            this.inputDirBrowseButton.Location = new System.Drawing.Point(684, 6);
            this.inputDirBrowseButton.Name = "inputDirBrowseButton";
            this.inputDirBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.inputDirBrowseButton.TabIndex = 15;
            this.inputDirBrowseButton.Text = "Browse...";
            this.inputDirBrowseButton.UseVisualStyleBackColor = true;
            this.inputDirBrowseButton.Click += new System.EventHandler(this.inputDirBrowseButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Directory to split";
            // 
            // splitInputDirTextBox
            // 
            this.splitInputDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitInputDirTextBox.Location = new System.Drawing.Point(86, 8);
            this.splitInputDirTextBox.Name = "splitInputDirTextBox";
            this.splitInputDirTextBox.Size = new System.Drawing.Size(592, 20);
            this.splitInputDirTextBox.TabIndex = 10;
            this.splitInputDirTextBox.Text = ".\\test1";
            this.splitInputDirTextBox.TextChanged += new System.EventHandler(this.splitInputDirTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Disperse into";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(148, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "files (min: 2; max: 4)";
            // 
            // splitDirNTextBox
            // 
            this.splitDirNTextBox.Location = new System.Drawing.Point(86, 74);
            this.splitDirNTextBox.Name = "splitDirNTextBox";
            this.splitDirNTextBox.Size = new System.Drawing.Size(56, 20);
            this.splitDirNTextBox.TabIndex = 14;
            this.splitDirNTextBox.Text = "3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainProgressBar);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 203);
            this.panel1.TabIndex = 10;
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProgressBar.Location = new System.Drawing.Point(12, 4);
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(776, 23);
            this.mainProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.mainProgressBar.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Output directory";
            // 
            // splitOutputDirTextBox
            // 
            this.splitOutputDirTextBox.Enabled = false;
            this.splitOutputDirTextBox.Location = new System.Drawing.Point(83, 33);
            this.splitOutputDirTextBox.Name = "splitOutputDirTextBox";
            this.splitOutputDirTextBox.Size = new System.Drawing.Size(595, 20);
            this.splitOutputDirTextBox.TabIndex = 34;
            this.splitOutputDirTextBox.Text = ".\\.test1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "FileSplitter - web 3.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox splitInputFileTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox splitNTextBox;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mergeInputFileTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mergeNTextBox;
        private System.Windows.Forms.ProgressBar mainProgressBar;
        private System.Windows.Forms.TextBox splitOutputFileTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button outputBrowseButton;
        private System.Windows.Forms.Button inputBrowseButton;
        private System.Windows.Forms.Button outputMergeBrowseButton;
        private System.Windows.Forms.Button inputMergeBrowseButton;
        private System.Windows.Forms.TextBox mergeOutputFileTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button inputDirBrowseButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox splitInputDirTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox splitDirNTextBox;
        private System.Windows.Forms.TextBox descriptionDir4TextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox descriptionDir3TextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox descriptionDir2TextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox descriptionDir1TextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button disperseButton;
        private System.Windows.Forms.Button concentrateButton;
        private System.Windows.Forms.Button syncButton;
        private System.Windows.Forms.Button generateFoldersButton;
        private System.Windows.Forms.TextBox additionalInfoDir4TextBox;
        private System.Windows.Forms.TextBox additionalInfoDir3TextBox;
        private System.Windows.Forms.TextBox additionalInfoDir2TextBox;
        private System.Windows.Forms.TextBox additionalInfoDir1TextBox;
        private System.Windows.Forms.TextBox splitOutputDirTextBox;
        private System.Windows.Forms.Label label18;
    }
}


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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.mergeInputFileTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mergeNTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.splitOutputFileTextBox = new System.Windows.Forms.TextBox();
            this.inputBrowseButton = new System.Windows.Forms.Button();
            this.outputBrowseButton = new System.Windows.Forms.Button();
            this.outputMergeBrowseButton = new System.Windows.Forms.Button();
            this.inputMergeBrowseButton = new System.Windows.Forms.Button();
            this.mergeOutputFileTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.mainTabControl.Location = new System.Drawing.Point(12, 27);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(776, 218);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.mainProgressBar);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 247);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Output directory";
            // 
            // splitOutputFileTextBox
            // 
            this.splitOutputFileTextBox.Location = new System.Drawing.Point(89, 32);
            this.splitOutputFileTextBox.Name = "splitOutputFileTextBox";
            this.splitOutputFileTextBox.Size = new System.Drawing.Size(592, 20);
            this.splitOutputFileTextBox.TabIndex = 8;
            this.splitOutputFileTextBox.Text = ".test.txt";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Output file should be the same as original filename!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}


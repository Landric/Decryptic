namespace Decryptic
{
    partial class MainForm
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
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDecrypticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoTab = new System.Windows.Forms.TabPage();
            this.freqTab = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.cipherTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.analyseButton = new System.Windows.Forms.Button();
            this.cipherTextBox = new System.Windows.Forms.TextBox();
            this.plainTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.cipherTab.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 17);
            this.statusLabel.Text = "Done";
            this.statusLabel.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.Visible = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 420);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(870, 22);
            this.statusStrip.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(870, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFromFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openFromFileToolStripMenuItem
            // 
            this.openFromFileToolStripMenuItem.Name = "openFromFileToolStripMenuItem";
            this.openFromFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFromFileToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openFromFileToolStripMenuItem.Text = "&Open from file";
            this.openFromFileToolStripMenuItem.Click += new System.EventHandler(this.openFromFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutDecrypticToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutDecrypticToolStripMenuItem
            // 
            this.aboutDecrypticToolStripMenuItem.Name = "aboutDecrypticToolStripMenuItem";
            this.aboutDecrypticToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.aboutDecrypticToolStripMenuItem.Text = "About Decryptic";
            this.aboutDecrypticToolStripMenuItem.Click += new System.EventHandler(this.aboutDecrypticToolStripMenuItem_Click);
            // 
            // infoTab
            // 
            this.infoTab.Location = new System.Drawing.Point(4, 22);
            this.infoTab.Name = "infoTab";
            this.infoTab.Size = new System.Drawing.Size(862, 392);
            this.infoTab.TabIndex = 2;
            this.infoTab.Text = "Other Information";
            this.infoTab.UseVisualStyleBackColor = true;
            // 
            // freqTab
            // 
            this.freqTab.Location = new System.Drawing.Point(4, 22);
            this.freqTab.Name = "freqTab";
            this.freqTab.Padding = new System.Windows.Forms.Padding(3);
            this.freqTab.Size = new System.Drawing.Size(862, 392);
            this.freqTab.TabIndex = 1;
            this.freqTab.Text = "Frequency Analysis";
            this.freqTab.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.cipherTab);
            this.tabControl.Controls.Add(this.freqTab);
            this.tabControl.Controls.Add(this.infoTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(870, 396);
            this.tabControl.TabIndex = 0;
            // 
            // cipherTab
            // 
            this.cipherTab.Controls.Add(this.tableLayoutPanel);
            this.cipherTab.Location = new System.Drawing.Point(4, 22);
            this.cipherTab.Name = "cipherTab";
            this.cipherTab.Padding = new System.Windows.Forms.Padding(3);
            this.cipherTab.Size = new System.Drawing.Size(862, 370);
            this.cipherTab.TabIndex = 0;
            this.cipherTab.Text = "Ciphertext";
            this.cipherTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.cipherTextBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.plainTextBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.analyseButton, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(856, 364);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // analyseButton
            // 
            this.analyseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel.SetColumnSpan(this.analyseButton, 2);
            this.analyseButton.Location = new System.Drawing.Point(374, 306);
            this.analyseButton.Name = "analyseButton";
            this.analyseButton.Size = new System.Drawing.Size(107, 44);
            this.analyseButton.TabIndex = 0;
            this.analyseButton.Text = "Analyse and decrypt";
            this.analyseButton.UseVisualStyleBackColor = true;
            // 
            // cipherTextBox
            // 
            this.cipherTextBox.AcceptsReturn = true;
            this.cipherTextBox.AcceptsTab = true;
            this.cipherTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cipherTextBox.Location = new System.Drawing.Point(3, 3);
            this.cipherTextBox.Multiline = true;
            this.cipherTextBox.Name = "cipherTextBox";
            this.cipherTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cipherTextBox.Size = new System.Drawing.Size(422, 297);
            this.cipherTextBox.TabIndex = 1;
            this.cipherTextBox.Text = "Enter the cipher text here (or load it from a file)";
            // 
            // plainTextBox
            // 
            this.plainTextBox.AcceptsReturn = true;
            this.plainTextBox.AcceptsTab = true;
            this.plainTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.plainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plainTextBox.Location = new System.Drawing.Point(431, 3);
            this.plainTextBox.Multiline = true;
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.ReadOnly = true;
            this.plainTextBox.Size = new System.Drawing.Size(422, 297);
            this.plainTextBox.TabIndex = 2;
            this.plainTextBox.Text = "The plain text will be displayed here";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 442);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.Name = "MainForm";
            this.Text = "Decrpytic";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.cipherTab.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDecrypticToolStripMenuItem;
        private System.Windows.Forms.TabPage infoTab;
        private System.Windows.Forms.TabPage freqTab;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage cipherTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button analyseButton;
        private System.Windows.Forms.TextBox cipherTextBox;
        private System.Windows.Forms.TextBox plainTextBox;
    }
}
namespace Video_Processing__AI__Machine_Learning
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoPanel = new System.Windows.Forms.Panel();
            this.videoListBox = new System.Windows.Forms.ListBox();
            this.analizationPanel = new System.Windows.Forms.SplitContainer();
            this.analyzeBtn = new System.Windows.Forms.Button();
            this.analizationProgressBar = new System.Windows.Forms.ProgressBar();
            this.filename = new System.Windows.Forms.Label();
            this.format = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.videoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.analizationPanel)).BeginInit();
            this.analizationPanel.Panel1.SuspendLayout();
            this.analizationPanel.Panel2.SuspendLayout();
            this.analizationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // videoPanel
            // 
            this.videoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.videoPanel.AutoScroll = true;
            this.videoPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.videoPanel.Controls.Add(this.videoListBox);
            this.videoPanel.Location = new System.Drawing.Point(12, 31);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(371, 407);
            this.videoPanel.TabIndex = 1;
            // 
            // videoListBox
            // 
            this.videoListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoListBox.FormattingEnabled = true;
            this.videoListBox.ItemHeight = 16;
            this.videoListBox.Location = new System.Drawing.Point(0, 0);
            this.videoListBox.Name = "videoListBox";
            this.videoListBox.Size = new System.Drawing.Size(371, 407);
            this.videoListBox.TabIndex = 0;
            this.videoListBox.SelectedIndexChanged += new System.EventHandler(this.videoListBox_SelectedIndexChanged);
            // 
            // analizationPanel
            // 
            this.analizationPanel.Location = new System.Drawing.Point(400, 31);
            this.analizationPanel.Name = "analizationPanel";
            this.analizationPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // analizationPanel.Panel1
            // 
            this.analizationPanel.Panel1.Controls.Add(this.format);
            this.analizationPanel.Panel1.Controls.Add(this.filename);
            this.analizationPanel.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // analizationPanel.Panel2
            // 
            this.analizationPanel.Panel2.Controls.Add(this.analizationProgressBar);
            this.analizationPanel.Panel2.Controls.Add(this.analyzeBtn);
            this.analizationPanel.Size = new System.Drawing.Size(388, 407);
            this.analizationPanel.SplitterDistance = 282;
            this.analizationPanel.TabIndex = 2;
            // 
            // analyzeBtn
            // 
            this.analyzeBtn.Location = new System.Drawing.Point(116, 78);
            this.analyzeBtn.Name = "analyzeBtn";
            this.analyzeBtn.Size = new System.Drawing.Size(160, 26);
            this.analyzeBtn.TabIndex = 0;
            this.analyzeBtn.Text = "Analyze";
            this.analyzeBtn.UseVisualStyleBackColor = true;
            this.analyzeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // analizationProgressBar
            // 
            this.analizationProgressBar.Location = new System.Drawing.Point(41, 30);
            this.analizationProgressBar.Name = "analizationProgressBar";
            this.analizationProgressBar.Size = new System.Drawing.Size(308, 23);
            this.analizationProgressBar.TabIndex = 1;
            // 
            // filename
            // 
            this.filename.AutoSize = true;
            this.filename.Location = new System.Drawing.Point(15, 16);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(73, 17);
            this.filename.TabIndex = 0;
            this.filename.Text = "Filename: ";
            // 
            // format
            // 
            this.format.AutoSize = true;
            this.format.Location = new System.Drawing.Point(15, 33);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(56, 17);
            this.format.TabIndex = 1;
            this.format.Text = "Format:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.analizationPanel);
            this.Controls.Add(this.videoPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.videoPanel.ResumeLayout(false);
            this.analizationPanel.Panel1.ResumeLayout(false);
            this.analizationPanel.Panel1.PerformLayout();
            this.analizationPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.analizationPanel)).EndInit();
            this.analizationPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel videoPanel;
        private System.Windows.Forms.ListBox videoListBox;
        private System.Windows.Forms.SplitContainer analizationPanel;
        private System.Windows.Forms.Button analyzeBtn;
        private System.Windows.Forms.ProgressBar analizationProgressBar;
        private System.Windows.Forms.Label format;
        private System.Windows.Forms.Label filename;
    }
}


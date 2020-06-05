namespace VideoRandomizer
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
            this.browseFolderToSplitBtn = new System.Windows.Forms.Button();
            this.splitVideosBtn = new System.Windows.Forms.Button();
            this.mergeVideosBtn = new System.Windows.Forms.Button();
            this.browseFolderToMergeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browseFolderToSplitBtn
            // 
            this.browseFolderToSplitBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.browseFolderToSplitBtn.Location = new System.Drawing.Point(0, 0);
            this.browseFolderToSplitBtn.Name = "browseFolderToSplitBtn";
            this.browseFolderToSplitBtn.Size = new System.Drawing.Size(298, 23);
            this.browseFolderToSplitBtn.TabIndex = 0;
            this.browseFolderToSplitBtn.Text = "Select Folder of Videos to Split";
            this.browseFolderToSplitBtn.UseVisualStyleBackColor = true;
            this.browseFolderToSplitBtn.Click += new System.EventHandler(this.browseFolderToSplitBtn_Click);
            // 
            // splitVideosBtn
            // 
            this.splitVideosBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitVideosBtn.Enabled = false;
            this.splitVideosBtn.Location = new System.Drawing.Point(0, 23);
            this.splitVideosBtn.Name = "splitVideosBtn";
            this.splitVideosBtn.Size = new System.Drawing.Size(298, 23);
            this.splitVideosBtn.TabIndex = 1;
            this.splitVideosBtn.Text = "Split Videos";
            this.splitVideosBtn.UseVisualStyleBackColor = true;
            this.splitVideosBtn.Click += new System.EventHandler(this.splitVideosBtn_Click);
            // 
            // mergeVideosBtn
            // 
            this.mergeVideosBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mergeVideosBtn.Enabled = false;
            this.mergeVideosBtn.Location = new System.Drawing.Point(0, 127);
            this.mergeVideosBtn.Name = "mergeVideosBtn";
            this.mergeVideosBtn.Size = new System.Drawing.Size(298, 23);
            this.mergeVideosBtn.TabIndex = 2;
            this.mergeVideosBtn.Text = "Merge Videos";
            this.mergeVideosBtn.UseVisualStyleBackColor = true;
            this.mergeVideosBtn.Click += new System.EventHandler(this.mergeVideosBtn_Click);
            // 
            // browseFolderToMergeBtn
            // 
            this.browseFolderToMergeBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.browseFolderToMergeBtn.Location = new System.Drawing.Point(0, 104);
            this.browseFolderToMergeBtn.Name = "browseFolderToMergeBtn";
            this.browseFolderToMergeBtn.Size = new System.Drawing.Size(298, 23);
            this.browseFolderToMergeBtn.TabIndex = 3;
            this.browseFolderToMergeBtn.Text = "Select Folder of Videos to Merge";
            this.browseFolderToMergeBtn.UseVisualStyleBackColor = true;
            this.browseFolderToMergeBtn.Click += new System.EventHandler(this.browseFolderToMergeBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 150);
            this.Controls.Add(this.browseFolderToMergeBtn);
            this.Controls.Add(this.mergeVideosBtn);
            this.Controls.Add(this.splitVideosBtn);
            this.Controls.Add(this.browseFolderToSplitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Randomizer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button browseFolderToSplitBtn;
        private System.Windows.Forms.Button splitVideosBtn;
        private System.Windows.Forms.Button mergeVideosBtn;
        private System.Windows.Forms.Button browseFolderToMergeBtn;
    }
}


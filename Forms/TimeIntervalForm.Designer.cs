namespace VideoRandomizer.Forms
{
    partial class TimeIntervalForm
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
            this.beginningLbl = new System.Windows.Forms.Label();
            this.secondsInterval = new System.Windows.Forms.NumericUpDown();
            this.secondsLbl = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.secondsInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // beginningLbl
            // 
            this.beginningLbl.AutoSize = true;
            this.beginningLbl.Location = new System.Drawing.Point(32, 28);
            this.beginningLbl.Name = "beginningLbl";
            this.beginningLbl.Size = new System.Drawing.Size(119, 13);
            this.beginningLbl.TabIndex = 0;
            this.beginningLbl.Text = "Split the Video(s) Every:";
            // 
            // secondsInterval
            // 
            this.secondsInterval.Location = new System.Drawing.Point(157, 26);
            this.secondsInterval.Name = "secondsInterval";
            this.secondsInterval.Size = new System.Drawing.Size(47, 20);
            this.secondsInterval.TabIndex = 1;
            this.secondsInterval.ValueChanged += new System.EventHandler(this.secondsInterval_ValueChanged);
            // 
            // secondsLbl
            // 
            this.secondsLbl.AutoSize = true;
            this.secondsLbl.Location = new System.Drawing.Point(210, 28);
            this.secondsLbl.Name = "secondsLbl";
            this.secondsLbl.Size = new System.Drawing.Size(97, 13);
            this.secondsLbl.TabIndex = 2;
            this.secondsLbl.Text = "Second / Seconds";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Enabled = false;
            this.confirmBtn.Location = new System.Drawing.Point(138, 67);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 3;
            this.confirmBtn.Text = "OK";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // TimeIntervalForm
            // 
            this.AcceptButton = this.confirmBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 102);
            this.ControlBox = false;
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.secondsLbl);
            this.Controls.Add(this.secondsInterval);
            this.Controls.Add(this.beginningLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeIntervalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provide a Time Interval";
            ((System.ComponentModel.ISupportInitialize)(this.secondsInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label beginningLbl;
        private System.Windows.Forms.NumericUpDown secondsInterval;
        private System.Windows.Forms.Label secondsLbl;
        private System.Windows.Forms.Button confirmBtn;
    }
}
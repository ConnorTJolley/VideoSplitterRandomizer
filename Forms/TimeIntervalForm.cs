using System;
using System.Windows.Forms;

namespace VideoRandomizer.Forms
{
    public partial class TimeIntervalForm : Form
    {
        public int ChosenInterval { get; set; }

        public TimeIntervalForm()
        {
            this.InitializeComponent();
        }

        private void secondsInterval_ValueChanged(object sender, EventArgs e)
        {
            this.ChosenInterval = Convert.ToInt32(this.secondsInterval.Value);
            this.confirmBtn.Enabled = this.ChosenInterval >= 1;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (this.HasConfirmed())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.secondsInterval.Focus();
            }
            
        }

        private bool HasConfirmed()
        {
            return MessageBox.Show($@"Split Video(s) Every {this.ChosenInterval} Seconds?", 
                @"Please Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
    }
}
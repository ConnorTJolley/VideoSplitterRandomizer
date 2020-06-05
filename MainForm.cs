
using System.Collections.Generic;
using VideoRandomizer.Classes;
using VideoRandomizer.Helpers;

namespace VideoRandomizer
{
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private string _directoryOfVideosToSplit;

        private string _directoryOfVideosToMerge;

        private readonly VideoSplitter _videoSplitter;

        private readonly VideoMerger _videoMerger;

        public MainForm()
        {
            this.InitializeComponent();
            this._videoSplitter = new VideoSplitter();
            this._videoMerger = new VideoMerger();
        }

        private void browseFolderToSplitBtn_Click(object sender, System.EventArgs e)
        {
            /*
             * Get the Directory, Set the Path and Check if Can Continue
             */
            this._directoryOfVideosToSplit = ValueRetriever.GetDirectory();
            this._videoSplitter.SetDirectory(this._directoryOfVideosToSplit);
            this.splitVideosBtn.Enabled = this._videoSplitter.CanPerformSplit();
        }

        private void browseFolderToMergeBtn_Click(object sender, System.EventArgs e)
        {
            /*
             * Get the Directory, Set the Path and Check if Can Continue
             */
            this._directoryOfVideosToMerge = ValueRetriever.GetDirectory();
            this._videoMerger.SetDirectory(this._directoryOfVideosToMerge);
            this.mergeVideosBtn.Enabled = this._videoMerger.CanPerformMerge();
        }

        private void splitVideosBtn_Click(object sender, System.EventArgs e)
        {
            if (!this._videoSplitter.CanPerformSplit())
            {
                return;
            }

            this.ToggleSplitButtonsState(false);

            this._videoSplitter.SplitVideos();

            this.ToggleSplitButtonsState(true);
        }

        private void ToggleSplitButtonsState(bool state)
        {
            this.splitVideosBtn.Enabled = state;
            this.browseFolderToSplitBtn.Enabled = state;
        }

        private void mergeVideosBtn_Click(object sender, System.EventArgs e)
        {
            if (!this._videoMerger.CanPerformMerge())
            {
                return;
            }

            this.ToggleMergeButtonState(false);

            this._videoMerger.MergeVideos();

            this.ToggleMergeButtonState(true);
        }

        private void ToggleMergeButtonState(bool state)
        {
            this.mergeVideosBtn.Enabled = state;
            this.browseFolderToMergeBtn.Enabled = state;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoRandomizer.Classes;

namespace VideoRandomizer.Helpers
{
    public class VideoSplitter : IVIdeoHelper
    {
        private int _timeInterval;

        public string Directory { get; set; }

        private List<VideoFIle> _videoFiles;

        public void SetDirectory(string splitVideoDirectory)
        {
            this.Directory = splitVideoDirectory;
        }

        public void ClearDirectory()
        {
            this.Directory = string.Empty;
        }

        public void SplitVideos()
        {
            if (!this.CanPerformSplit())
            {
                return;
            }

            this._timeInterval = ValueRetriever.GetTimeInterval();
            this._videoFiles = ValueRetriever.GetVideoFiles(this.Directory);

            if (this._videoFiles.Count == 0)
            {
                MessageBox.Show($@"No Files Found Inside of: {this.Directory}");
                return;
            }

            ValueRetriever.GetVideoDurations(this._videoFiles); //// This auto updates the List Objects
            this._videoFiles.ForEach(singleFile => { this.SplitVideoIntoChunks(singleFile, this._timeInterval); });
        }

        private void SplitVideoIntoChunks(VideoFIle singleFile, int timeInterval)
        {
            var command = ValueRetriever.GetSplitCommand(singleFile, timeInterval);
            CommandExecutor.CreateDirectoryForFile(singleFile); //// Create output Folder before doing Split
            CommandExecutor.RunCommand(command);
        }

        public bool CanPerformSplit()
        {
            return !string.IsNullOrWhiteSpace(this.Directory);
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoRandomizer.Classes;

namespace VideoRandomizer.Helpers
{
    public class VideoMerger : IVIdeoHelper
    {
        public string Directory { get; set; }

        private List<VideoFIle> _videoFiles;
        private string _mergeList;
        private string _outputLocation;

        public void SetDirectory(string directory)
        {
            this.Directory = directory;
        }

        public void ClearDirectory()
        {
            this.Directory = string.Empty;
        }

        public void MergeVideos()
        {
            if (!this.CanPerformMerge())
            {
                return;
            }

            ////TODO: Merge the Videos
            this._videoFiles = ValueRetriever.GetVideoFiles(this.Directory);
            if (this._videoFiles.Count == 0)
            {
                MessageBox.Show($@"No Files Found Inside of: {this.Directory}");
                return;
            }

            ValueRetriever.GetVideoDurations(this._videoFiles); //// This auto updates the List Objects
            this.MergeTogetherVideos();
        }

        private void MergeTogetherVideos()
        {
            this.ShuffleList();
            this.CreateMergeList();
            this.PromptSaveFile();
            this.WriteMergeList();
            var command = ValueRetriever.GetMergeCommand(this._outputLocation);
            CommandExecutor.RunCommand(command);
        }

        private void WriteMergeList()
        {
            try
            {
                File.WriteAllText(this._outputLocation, this._mergeList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PromptSaveFile()
        {
            try
            {
                var dialog = new SaveFileDialog
                {
                    Filter = "Text File (*.txt)|*.txt",
                    FileName = "outputlist.txt"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this._outputLocation = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateMergeList()
        {
            var mergeList = string.Empty;

            this._videoFiles.ForEach(singleVideo =>
                {
                    mergeList += $"file '{singleVideo.FileName}'{Environment.NewLine}";
                });

            this._mergeList = mergeList;
        }

        private void ShuffleList()
        {
            var random = new Random();

            var n = this._videoFiles.Count;
            while (n > 1)
            {
                n--;
                var k = random.Next(n + 1);
                var value = this._videoFiles[k];
                this._videoFiles[k] = this._videoFiles[n];
                this._videoFiles[n] = value;
            }

            /*
            for (var i = 0; i < this._videoFiles.Count - 1;)
            {
                tempItem = this._videoFiles[random.Next(0, this._videoFiles.Count - 1)];
                if (tempList.Contains(tempItem))
                {
                    tempItem = this._videoFiles[random.Next(0, this._videoFiles.Count - 1)];
                }
                else
                {
                    tempList.Add(tempItem);
                    i++;
                }
            }*/
        }

        public bool CanPerformMerge()
        {
            return !string.IsNullOrWhiteSpace(this.Directory);
        }
    }
}
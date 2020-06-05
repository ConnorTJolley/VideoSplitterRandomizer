using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MediaToolkit;
using VideoRandomizer.Classes;
using VideoRandomizer.Forms;

namespace VideoRandomizer.Helpers
{
    public static class ValueRetriever
    {
        public static string GetDirectory()
        {
            var directory = string.Empty;

            try
            {
                using (var browser = new FolderBrowserDialog())
                {
                    if (browser.ShowDialog() == DialogResult.OK)
                    {
                        directory = browser.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return string.Empty;
            }

            return directory;
        }

        public static int GetTimeInterval()
        {
            var interval = 0;

            try
            {
                var dialog = new TimeIntervalForm();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    interval = dialog.ChosenInterval;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return interval;
        }

        public static List<VideoFIle> GetVideoFiles(string directory)
        {
            var directories = Directory.GetDirectories(directory).ToList();
            var files = new List<VideoFIle>();
            if (directories.Count > 0)
            {
                directories.ForEach(singleDir =>
                {
                    var directoryFiles = Directory.GetFiles(singleDir).ToList();
                    directoryFiles.ForEach(singleFile =>
                    {
                        if (singleFile.EndsWith(@".mp4"))
                        {
                            files.Add(new VideoFIle(singleFile, singleDir));
                        }
                    });
                });
            }

            var rootFiles = Directory.GetFiles(directory).ToList();
            rootFiles.ForEach(singleFile =>
            {
                if (singleFile.EndsWith(@".mp4"))
                {
                    files.Add(new VideoFIle(singleFile, directory));
                }
            });

            return files;
        }

        public static void GetVideoDurations(List<VideoFIle> videoFiles)
        {
            videoFiles.ForEach(singleVideo =>
                {
                    singleVideo.DurationInTicks = ValueRetriever.GetVideoInfo(singleVideo.FileName).Item3;
                    singleVideo.DurationInSeconds = ValueRetriever.TickToSeconds(singleVideo.DurationInTicks);
                });
        }

        private static double TickToSeconds(long ticks)
        {
            return TimeSpan.FromTicks(ticks).TotalSeconds;
        }

        public static Tuple<int, int, long> GetVideoInfo(string fileName)
        {
            var inputFile = new MediaToolkit.Model.MediaFile { Filename = fileName };
            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);
            }

            // FrameSize is returned as '1280x768' string.
            var size = inputFile.Metadata.VideoData
                .FrameSize.Split(new[] { 'x' })
                .Select(o => int.Parse(o)).ToArray();

            return new Tuple<int, int, long>(size[0], size[1], inputFile.Metadata.Duration.Ticks);
        }

        public static string GetSplitCommand(VideoFIle singleFile, int timeInterval)
        {
            var ffmpegDir = "C:\\Users\\connor.jolley\\Desktop\\ffmpegDir\\";
            var outputPath = ValueRetriever.GetFileOutputPath(singleFile);
            var endFileName = ValueRetriever.GetEndFileName(singleFile);
            return $@"/K {ffmpegDir}ffmpeg.exe -i {singleFile.FileName} -c copy -map 0 -segment_time {timeInterval} -f segment {outputPath}{endFileName}%03d.mp4";
        }

        private static string GetEndFileName(VideoFIle singleFile)
        {
            return Path.GetFileName(singleFile.FileName)?.Split('.')[0];
        }

        public static string GetFileOutputPath(VideoFIle singleFile)
        {
            var endFileName = Path.GetFileName(singleFile.FileName)?.Split('.')[0];
            return singleFile.Directory + $@"\\{endFileName}\\";
        }

        public static string GetMergeCommand(string outputLocation)
        {
            var ffmpegDir = "C:\\Users\\connor.jolley\\Desktop\\ffmpegDir\\";
            var outputFile = "C:\\Users\\connor.jolley\\Desktop\\OutputVideoMerges\\output.mp4";
            return $@"/K {ffmpegDir}ffmpeg.exe -f concat -safe 0 -i {outputLocation} -c copy {outputFile}";
        }
    }
}
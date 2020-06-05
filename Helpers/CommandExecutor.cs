using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using VideoRandomizer.Classes;

namespace VideoRandomizer.Helpers
{
    public static class CommandExecutor
    {
        public static void RunCommand(string command)
        {
            Process.Start("CMD.exe", command);
        }

        public static void CreateDirectoryForFile(VideoFIle singleFile)
        {
            var outputPath = ValueRetriever.GetFileOutputPath(singleFile);

            try
            {
                Directory.CreateDirectory(outputPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CreateDirectoryForFile(string directory)
        {
            try
            {
                Directory.CreateDirectory(directory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
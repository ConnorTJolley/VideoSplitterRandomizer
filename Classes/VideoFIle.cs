
namespace VideoRandomizer.Classes
{
    using System;

    public class VideoFIle
    {
        public Guid ID { get; private set; }
        public string Directory { get; set; }
        public string FileName { get; set; }
        public long DurationInTicks { get; set; }
        public double DurationInSeconds { get; set; }

        public VideoFIle(string fileName, string directory)
        {
            this.ID = Guid.NewGuid();
            this.FileName = fileName;
            this.Directory = directory;
        }
    }
}
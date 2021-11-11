using System;
using System.IO;

namespace MediaLibrary.Media
{
    public class Audio : IMedia
    {
        public int Quality { get; set; }
        public string Duration { get; set; }
        public string Author { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Stream GetStream()
        {
            throw new NotImplementedException();
        }
    }
}
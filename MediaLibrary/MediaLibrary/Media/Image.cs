using System;
using System.IO;

namespace MediaLibrary.Media
{
    public class Image : IMedia
    {
        public string Resolution { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Stream GetStream()
        {
            throw new NotImplementedException();
        }
    }
}
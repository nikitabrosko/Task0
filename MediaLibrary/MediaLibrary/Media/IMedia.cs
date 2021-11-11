using System.IO;

namespace MediaLibrary.Media
{
    public interface IMedia
    {
        string Location { get; set; }
        Stream GetStream();
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
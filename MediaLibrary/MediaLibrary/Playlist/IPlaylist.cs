using System.Collections.Generic;
using MediaLibrary.Media;

namespace MediaLibrary.Playlist
{
    public interface IPlaylist : IEnumerator<IMedia>
    {
        public void Add(IMedia media);
        public IMedia GetPrevious();
        public void Remove(IMedia media);
        public void RemoveAt(int index);
        public void Mode();
    }
}
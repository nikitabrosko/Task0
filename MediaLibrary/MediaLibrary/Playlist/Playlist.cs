using System;
using System.Collections;
using MediaLibrary.Media;

namespace MediaLibrary.Playlist
{
    public class Playlist : IPlaylist
    {
        public IMedia Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Add(IMedia media)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IMedia GetPrevious()
        {
            throw new NotImplementedException();
        }

        public void Mode()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Remove(IMedia media)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
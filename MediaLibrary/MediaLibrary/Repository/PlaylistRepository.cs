using System;
using System.Collections.Generic;
using MediaLibrary.Playlist;

namespace MediaLibrary.Repository
{
    class PlaylistRepository : IRepository<IPlaylist>
    {
        public void Add(IPlaylist media)
        {
            throw new NotImplementedException();
        }

        public IPlaylist Get(string playlistId)
        {
            throw new NotImplementedException();
        }

        public IList<IPlaylist> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<IPlaylist> GetAll(string filter)
        {
            throw new NotImplementedException();
        }

        public void Remove(IPlaylist media)
        {
            throw new NotImplementedException();
        }

        public void Update(IPlaylist media)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.Playlist;
using MediaLibrary.Repository;

namespace MediaLibrary
{
    class Facade
    {
        private readonly IRepository<IPlaylist> _playlistRepository;

        public Facade(IRepository<IPlaylist> playlistRepository)
        {
            _playlistRepository = playlistRepository;
        }
    }
}

using System;
using MediaLibrary.Playlist;

namespace MediaLibrary.Media
{
    public class MainPlayer
    {
        private IPlayerFactory _player;

        public void Start(IPlaylist playlist)
        {
            while (playlist.MoveNext())
            {
                _player.Create(playlist.Current).Play(playlist.Current);
            }
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
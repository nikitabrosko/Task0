using Microsoft.Extensions.DependencyInjection;
using System;
using MediaLibrary.Media;
using MediaLibrary.Playlist;
using MediaLibrary.Repository;

namespace MediaLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var containerBuilder = new ServiceCollection();

            containerBuilder.AddScoped<IRepository<IPlaylist>, PlaylistRepository>();
            containerBuilder.AddScoped<Facade, Facade>();

            var serviceProvider = containerBuilder.BuildServiceProvider();
            var facade = serviceProvider.GetService<Facade>();

            var playlistRepository = new PlaylistRepository();
            var mainPlayer = new MainPlayer();

            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "sp":
                        playlistRepository.GetAll();
                        break;
                    case "pp":
                        var playlistId = Console.ReadLine();
                        var selectedPlaylist = playlistRepository.Get(playlistId);
                        mainPlayer.Start(selectedPlaylist);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

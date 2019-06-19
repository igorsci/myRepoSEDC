using MusicStoreWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreWebApp.Data
{
    public static class AlbumDataBase
    {
        static AlbumDataBase()
        {
            AlbumList = new List<Album>
            {
                new Album{Id=1,Name="Ramstein",NumberOfSongs=9,Price=10},
                new Album{Id=2,Name="Ramstein",NumberOfSongs=11,Price=12},
                new Album{Id=3,Name="Ramstein",NumberOfSongs=9,Price=15},
                new Album{Id=4,Name="Ramstein",NumberOfSongs=9,Price=25},

            };
        }

        public static List<Album> AlbumList { get; set; }
    }
}

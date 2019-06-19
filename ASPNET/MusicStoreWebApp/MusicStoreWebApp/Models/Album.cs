using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreWebApp.Models
{
    public class Album
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Price { get; set; }
        public int NumberOfSongs { get; set; }
    }
}

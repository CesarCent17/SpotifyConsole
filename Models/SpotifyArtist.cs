using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyConsole.Models
{
    //Clase que describe a un artista
    public class SpotifyArtist
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Followers { get; set; }
        public string Popularity { get; set; }
    }
}

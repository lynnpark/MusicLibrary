using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicLibrary.Models
{
    public class Artist
    {
        public int Id { get; set; }

        public string ArtistName { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }
    }
}
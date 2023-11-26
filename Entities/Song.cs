using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaveRadio.Models.Entities
{
    public class Song
    {
        [Key]
        public Guid song_id { get; set; }
        public string? song_name { get; set; }
        public string? song_artist { get; set; }
        public string? song_genre { get; set; }
        public string? song_path { get; set; }
        public string? song_image { get; set; }
        public string? song_uri { get; set; }
    }
}
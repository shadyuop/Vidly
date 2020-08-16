using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyT.Models
{
    public class Movie
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public byte Genre { get; set; }
        public string GenreName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime AddedDate { get; set; }
        public int Stock { get; set; }

    }
}
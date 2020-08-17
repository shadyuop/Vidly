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
        
        [Required]
        public byte GenreID { get; set; }
        
        public Genre Genre { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        
        public DateTime AddedDate { get; set; }
        
        public int Stock { get; set; }

    }
}
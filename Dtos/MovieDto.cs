using System;
using System.ComponentModel.DataAnnotations;
using VidlyT.Models;

namespace VidlyT.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Please enter Movie's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreID { get; set; }

        public DateTime ReleaseDate { get; set; }
        // public Genre Genre { get; set; }

        public DateTime AddedDate { get; set; }

        [Range(1, 20)]
        public int Stock { get; set; }
    }
}
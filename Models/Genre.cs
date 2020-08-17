﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyT.Models
{
    public class Genre
    {
        public byte Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public String Name { get; set; }
    }
}
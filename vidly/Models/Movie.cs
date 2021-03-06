﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:d MMM yyyy}")]
        public DateTime ReleaseDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:d MMM yyyy}")]
        [Display(Name = "Date Added to Database")]
        public DateTime DateAddedToDatabase { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1,20)]
        public int NumberInStock { get; set; }

        
        public int NumberAvailable { get; set; }

    }
}
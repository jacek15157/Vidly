﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Required (ErrorMessage = "Please enter date MM.DD.YYYY")]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please enter date MM.DD.YYYY")]
        [Display(Name = "Added Date")]
        public DateTime? DateAdded { get; set; }

        [Required]
        [Range(1,20)]
        [Display(Name = "Number in stock")]
        public int? NumberInStock { get; set; }

        
        [Range(0, 20)]
        public int? NumberOfAvailable { get; set; }
    }
}
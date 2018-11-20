using System;
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
        [QuantityRangeOfMoviesToAdd] //just for practice I create my own validation class, in this case you should use [Range(1,20)] it is prettier
        [Display(Name = "Number in stock")]
        public int? NumberInStock { get; set; }
    }
}
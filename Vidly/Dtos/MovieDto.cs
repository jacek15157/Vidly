using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public GenreDto Genre { get; set; }

        //[Required]
        public byte GenreId { get; set; }

        //[Required(ErrorMessage = "Please enter date MM.DD.YYYY")]
        public DateTime? ReleaseDate { get; set; }

        //[Required(ErrorMessage = "Please enter date MM.DD.YYYY")]
        public DateTime? DateAdded { get; set; }

        //[Required]
       // [Range(1, 20)]
        public int? NumberInStock { get; set; }
        public int? NumberOfAvailable { get; set; }
    }
}
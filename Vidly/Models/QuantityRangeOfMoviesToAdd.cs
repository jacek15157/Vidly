using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class QuantityRangeOfMoviesToAdd : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie) validationContext.ObjectInstance;
            int quantity = 20;  //set a quantity which will be required

            return (movie.NumberInStock < quantity && movie.NumberInStock > 0)
                ? ValidationResult.Success //if true
                : new ValidationResult("You need to put quantity between 0 and 20");//else
            
        }
    }
}
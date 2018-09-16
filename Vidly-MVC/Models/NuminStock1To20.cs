using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_MVC.Models
{
    public class NuminStock1To20 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.NumberInStock > 1 || movie.NumberInStock < 20)
            {
                return ValidationResult.Success;
            }

            else
                return new ValidationResult("The field Number in Stock must be between 1 and 20");
            
        }

    }
}
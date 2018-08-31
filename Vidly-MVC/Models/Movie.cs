using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_MVC.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Release Date")]
        public string ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        public string DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }
        
        public GenreType GenreType { get; set; }

        [Required]
        [Display(Name = "Genre Type")]
        public byte GenreTypeId { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly_MVC.Models;

namespace Vidly_MVC.ViewModel
{
    public class MovieFormViewModel
    {
        public IEnumerable<GenreType> GenreTypes { get; set; }
        //public Movie Movie { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0: d MMM yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime? ReleaseDate { get; set; }


        [Display(Name = "Number In Stock")]
        [NuminStock1To20]
        [Range(1, 20)]
        public byte? NumberInStock { get; set; }

        [Required]
        [Display(Name = "Genre Type")]
        public byte? GenreTypeId { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreTypeId = movie.GenreTypeId;
        }
    }

    
}
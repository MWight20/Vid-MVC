using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_MVC.Models;
using System.ComponentModel.DataAnnotations;

namespace Vidly_MVC.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        
        public DateTime DateAdded { get; set; }
                
        //[NuminStock1To20]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
        
        [Required]
        public byte GenreTypeId { get; set; }
    }
}
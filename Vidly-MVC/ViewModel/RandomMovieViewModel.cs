using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_MVC.Models;

namespace Vidly_MVC.viewModel
{
    public class RandomMovieViewModel
    {
        public List<Customer> customerName { get; set; }
        public List<Movie> moviesModel { get; set; }
        public List<Customer> customerModel { get; set; }
    }
}
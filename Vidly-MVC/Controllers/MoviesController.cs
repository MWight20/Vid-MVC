using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_MVC.Models;
using Vidly_MVC.viewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        public ActionResult ByReleaseDate()
        {
            return View();
        }

        // GET: Movies
        public ActionResult MoviesPage()
        {
            Movie movie = new Movie() { Name = "Shrek" };
            List<Movie> movies = new List<Movie>
            {
                new Movie { Name = "Shrek" },
                new Movie { Name = "Wall-e" }
            };

            RandomMovieViewModel movieViewModel = new RandomMovieViewModel()
            {
                moviesModel = movies
            };

            return View(movieViewModel);

        }
    }
}
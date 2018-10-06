using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly_MVC.Dtos;
using Vidly_MVC.Models;

namespace Vidly_MVC.Controllers.Api
{
    [Authorize(Roles = RoleName.CanManageMovies)]
    public class NewRentalsController : ApiController
    {
        // PURPOSE: assigning selected movies to a customer by assigning a new "rental" object. Each rental will be contained as an object

        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            //START DEFENSIVE CODE METHODS
            //

            //if (newRental.MovieIds.Count == 0)
            //    return BadRequest("No Movie Ids have been given.");

            ////1. get customer
            //var Customer = _context.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId);

            //if (Customer == null)
            //    return BadRequest("CustomerId is not valid");

            
            ////2. get movie
            //var Movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

            //if (Movies.Count != newRental.MovieIds.Count)
            //    return BadRequest("One or more movieIds are invalid.");

            ////3. for each movie we need to assign a new rental object.
            //foreach (var movie in Movies)
            //{
            //    if (movie.NumberAvailable == 0)
            //        return BadRequest("Movie is not available.");

            //    movie.NumberAvailable--;

            //    var rental = new Rental
            //    {
            //        Customer = Customer,
            //        Movie = movie,
            //        DateRented = DateTime.Now
            //    };

            //    //4. Add the rental objects to the DB.
            //    _context.Rentals.Add(rental);
            //}

            //_context.SaveChanges();
            //return Ok();
            
            //
            //END DEFENSIVE CODE METHODS


            //START OPTIMISTIC CODE METHODS:
            
            //1. get customer
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
            
            //2. get movie
            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();
            
            //3. for each movie we need to assign a new rental object.
            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available.");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                //4. Add the rental objects to the DB.
                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
            //END OPTIMISTIC CODE METHODS
        }
        

    }
}

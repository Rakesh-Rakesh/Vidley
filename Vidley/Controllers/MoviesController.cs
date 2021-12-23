using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidley.Models;
using Vidley.ViewModels;

namespace Vidley.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek !"
            };
            var customers = new List<Customer>
            {
                new Customer{Name="CUstomer 1"},
                new Customer{Name="CUstomer 2"}
            };

            var viewModel = new RandomMovieViewModel() {
                Movie = movie,
                Customers=customers
            };


            return View(viewModel);
        }
        
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year + "/" + month);
        }
    }
}
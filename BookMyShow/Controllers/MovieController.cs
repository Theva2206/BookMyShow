using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BookMyShow.Models;
using BookMyShow.ViewModels;
using Microsoft.Ajax.Utilities;

namespace BookMyShow.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/ShowMovie
        [Route("Movie/MovieList")]
        public ActionResult ShowMovies()
        {
            var movieList = new Movie {MovieId = 100, MovieName = "Theva"};
            //var movieList1 = new List<Movie>
            //{
            //    new Movie {MovieId = 100, MovieName = "Theva"},
            //    new Movie {MovieId = 101, MovieName = "Priya"}
            //};
            //return View(movieList);
            return Content("Hi Theva");
            //return RedirectToAction("Index", "Home", new {id=1, name="Dil"});
        }

        [Route("Movie/test/{id:regex(\\d{2})}/{name}")]
        public ActionResult ConventionBasedRouting(int? id, string name)
        {
            if (!id.HasValue)
                id = 100;
            if (name.IsNullOrWhiteSpace())
                name = "Theva";
            return Content(String.Format("ID is = {0} & Name value is = {1}", id, name));
        }

        public ActionResult ShowViewBagMultiVal()
        {
            //new Movie() { MovieId = 1001, MovieName = "96" };
            ViewBag.Title = "Magic String Title";
            ViewBag.Description = "Viewbag used to return collection of data in less quantity..."; 
            ViewBag.MovieData = "Hi Theva. It's me Viewbag da... :)";
            ViewBag.MovieDetails = new Movie {MovieId = 109, MovieName = "96 Vj Movie"};
            ViewBag.MovieList = new List<Movie>
            {
                new Movie() {MovieId = 1000, MovieName = "Theva"},
                new Movie() {MovieId = 1001, MovieName = "Shan"},
                new Movie() {MovieId = 1002, MovieName = "Sarathy"},
                new Movie(){MovieId = 1003, MovieName = "Prem"}
            };
            return View();
        }

        public ActionResult ShowViewModelMultiVal()
        {
            var movie = new Movie { MovieId = 109, MovieName = "96 Vj Movie" };
            var cust = new List<Customer>
            {
                new Customer() {CustID = 1000, CustName = "Theva"},
                new Customer() {CustID = 1001, CustName = "Shan"},
                new Customer() {CustID = 1002, CustName = "Sarathy"},
                new Customer() {CustID = 1003, CustName = "Prem"}
            };

            var VMMovieCustObj = new MovieCustomerViewModel
            {
                Movie = movie,
                Customers = cust
            };
            return View(VMMovieCustObj);
        }
    }
}
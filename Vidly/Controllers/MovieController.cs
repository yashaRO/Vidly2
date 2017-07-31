using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public IEnumerable<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie("Big Momma's House"),
                new Movie("Big Momma's Heart Surgery"),
                new Movie("Big Momma's Funeral"),
                new Movie("Big Momma isn't Dead!?"),
                new Movie("Big Momma's Seance"),
                new Movie("Big Momma's a Demon"),
                new Movie("Big Momma's Defiled Corpse"),
                new Movie("Big Momma's Finally Laid to Rest")
            };

            return movies;
        }
    }
}
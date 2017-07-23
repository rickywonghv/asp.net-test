using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class MovieController : Controller
    {
        public string[,] movies = new [,] { {"Movie1" ,"Movie1 Desc"}, { "Movie2", "Movie2 Desc" }, { "Movie3", "Movie3 Desc" }, { "Movie4", "Movie4 Desc" }, { "Movie5", "Movie5 Desc" } };

        public ActionResult Index()
        {
            int ran = new Random().Next(0, 4);
            var movie = new Movie()
            {

                Name = movies[ran, 0],
                Description = movies[ran, 1]
            };

            return View(movie);
        }

        // GET: Movie
        public ActionResult Random()
        {
            int ran = new Random().Next(0,4);
            var movie = new Movie()
            {

                Name = movies[ran, 0],
                Description = movies[ran,1]
            };

            return View(movie);
        }

        public ActionResult List(int id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            else
            {
                var movie = new Movie()
                {
                    Name = movies[id, 0],
                    Description = movies[id, 1]
                };
                return View(movie);
            }            
        }
    }
}
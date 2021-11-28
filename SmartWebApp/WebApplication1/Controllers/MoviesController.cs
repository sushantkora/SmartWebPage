using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartWebApp.Models;
using SmartWebApp.ViewModels;

namespace SmartWebApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        private MyDBContext _dbContext;

        public MoviesController()
        { 
            _dbContext = new MyDBContext();
        }
        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }
        public ActionResult Random()
        {

            var movies=_dbContext.Movies.ToList();
            var customers = new List<Customers>()
            {
                new Customers() { Id = 1,Name = "Herman" },
                new Customers() { Id = 2,Name ="Saranya"}
            };
            var viewModels = new RandomMovieViewModel()
            {
                Movies = movies,
                Customers = customers,
            };


            return View(viewModels);
        }
        [HttpPost]
        public ActionResult Save(Movies movie)
        {
            var movie_e= _dbContext.Movies.SingleOrDefault(c=>c.Id == movie.Id);
            if (movie_e == null)
            {
                _dbContext.Movies.Add(movie);
            }
            else
            { 
                movie_e.IMDB=movie.IMDB;
                movie_e.Title=movie.Title;
                movie_e.Date=movie.Date;
                movie.Genre=movie.Genre;
            }
            _dbContext.SaveChanges();
            return RedirectToAction("Random","Movies");
        }
        public ActionResult AddNewMovie()
        { 
            return View("NewMovieForm");
        }
        public ActionResult Details(int Id)
        { 
            var movie= _dbContext.Movies.SingleOrDefault(x => x.Id == Id);

            return View(movie);
        }

       

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if(!pageIndex.HasValue)
                    pageIndex = 1;  
            sortBy = "name";
            return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        }
        [Route("movies/releases/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year+"/"+month);
        }
    }
}
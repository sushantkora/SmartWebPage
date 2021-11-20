﻿using System;
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
        public ActionResult Random()
        {

            var movies = new List<Movies>()
            {
                new Movies() { Id = 1,Title = "Intesteller", Date=DateTime.Now,IMDB=9.2 },
                 new Movies() { Id = 1,Title = "Gladiator", Date=DateTime.Now,IMDB=9.1 },
                   new Movies() { Id = 1,Title = "Ganges Of Wasshhpur", Date=DateTime.Now,IMDB=8.5 },
                     new Movies() { Id = 1,Title = "Wolf of Wall Street", Date=DateTime.Now,IMDB=6.7 },
            };
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
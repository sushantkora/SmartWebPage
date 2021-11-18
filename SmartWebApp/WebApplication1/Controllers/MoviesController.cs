using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartWebApp.Models;

namespace SmartWebApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movies() { Title ="Intesteller",Id=1,Date =DateTime.Now,Count=1};
            
            return View(movie);
        }
    }
}
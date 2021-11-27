using SmartWebApp.Models;
using SmartWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartWebApp.Controllers
{
    public class CustomersController : Controller
    {
        private MyDBContext _context;

        public CustomersController()
        {
            _context = new MyDBContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        [Route("customers/index")]
        public ActionResult Customers()
        {
            var movies = new List<Movies>()
            {
                new Movies() { Id = 1,Title = "Intesteller", Date=DateTime.Now,IMDB=9.2 },
                 new Movies() { Id = 1,Title = "Gladiator", Date=DateTime.Now,IMDB=9.1 },
                   new Movies() { Id = 1,Title = "Ganges Of Wasshhpur", Date=DateTime.Now,IMDB=8.5 },
                     new Movies() { Id = 1,Title = "Wolf of Wall Street", Date=DateTime.Now,IMDB=6.7 },
            };
            var customer = _context.Customers.Include(c=>c.MembershipType).ToList();
            var viewModels = new RandomMovieViewModel()
            {
                Movies = movies,
                Customers = (List<Customers>)customer,
            };

            return View(viewModels);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        /*private IEnumerable<Customers> GetCustomers()
        {
            var customers = new List<Customers>()
            {
                new Customers() { Id = 1,Name = "Hermaan" },
                new Customers() { Id = 2,Name ="Saranya"}
            };

            return customers;

        }*/
    }
}
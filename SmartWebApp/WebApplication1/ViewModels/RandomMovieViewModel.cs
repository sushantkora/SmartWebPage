using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartWebApp.Models;

namespace SmartWebApp.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Movies>  Movies { get; set; }
        public List<Customers> Customers { get; set; }
    }
}
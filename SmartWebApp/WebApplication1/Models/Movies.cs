using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartWebApp.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Genre { get; set; }
        public DateTime Date { get; set; }
        public double IMDB { get; set; }

    }
}
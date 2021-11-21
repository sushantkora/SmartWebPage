using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SmartWebApp.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext()
        {

        }
        public DbSet<Customers> Customers { get; set; } // My domain models
        public DbSet<Movies> Movies { get; set; }// My domain models

        public DbSet<MembershipType> MembershipType { get; set; }
    }
}
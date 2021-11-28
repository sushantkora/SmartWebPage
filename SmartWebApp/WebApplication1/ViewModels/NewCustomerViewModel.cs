using SmartWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartWebApp.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> membershipTypes { get; set; }
        public Customers customers { get; set; }

    }
}
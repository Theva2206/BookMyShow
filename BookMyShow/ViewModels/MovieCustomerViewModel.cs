using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookMyShow.Models;

namespace BookMyShow.ViewModels
{
    public class MovieCustomerViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
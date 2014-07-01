using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Domain.Models;

namespace Site.ViewModel
{
    public class PageViewModel
    {
        public IList<Product> product { get; set; }
        public int Page{get; set;}
        public int PageAll { get; set; }
        public int NumberOfElements { get; set; }
    }
}
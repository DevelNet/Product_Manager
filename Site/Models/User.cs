using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Site.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public int? Age { get; set; }

        public string Phone { get; set; }

        public double? Balance { get; set; }
    }
}
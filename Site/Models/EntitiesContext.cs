using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext()
            : base("defaultConnection")
        {
            
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; } 
    }
}
using System.Data.Entity;
using Domain.Models;

namespace Data.Contexts
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
using System.Data.Entity;
using Data.Mappings;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Product_Mapping());
            modelBuilder.Configurations.Add(new Category_Mapping());
        }
    }
}
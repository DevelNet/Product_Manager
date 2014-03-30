using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class Product_Mapping : EntityTypeConfiguration<Product>
    {
        public Product_Mapping()
        {
            HasKey(x => x.Id);

            ToTable("Products");

            Property(x => x.Name).IsOptional().HasMaxLength(32);
            Property(x => x.Price).IsOptional();
            Property(x => x.PurchaseCost).IsOptional();
            Property(x => x.Quantity).IsOptional();

            HasOptional(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
        }
    }
}
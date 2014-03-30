using System.Data.Entity.ModelConfiguration;
using Domain.Models;

namespace Data.Mappings
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
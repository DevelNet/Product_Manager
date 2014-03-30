using System.Data.Entity.ModelConfiguration;
using Domain.Models;

namespace Data.Mappings
{
    public class Category_Mapping : EntityTypeConfiguration<Category>
    {
        public Category_Mapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Name).IsRequired();
        }
    }
}
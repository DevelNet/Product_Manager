using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Site.Models
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
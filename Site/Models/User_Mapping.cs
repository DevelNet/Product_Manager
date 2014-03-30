using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class User_Mapping : EntityTypeConfiguration<User>
    {
        public User_Mapping()
        {
            Property(x => x.Age).IsOptional();
            Property(x => x.Name).IsRequired().HasMaxLength(24);
            Property(x => x.Email).IsRequired();
            Property(x => x.Phone).IsOptional().HasMaxLength(12);
            Property(x => x.Balance).IsOptional();
        }
    }
}
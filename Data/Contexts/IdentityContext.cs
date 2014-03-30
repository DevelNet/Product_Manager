using System.Data.Entity;
using Data.Mappings;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Data.Contexts
{
    public class IdentityContext : IdentityDbContext<User>
    {
        public IdentityContext()
            : base("defaultConnection")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new User_Mapping());
        }
    }
}
using Microsoft.AspNet.Identity.EntityFramework;

namespace Data.Contexts
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public int? Age { get; set; }

        public string Phone { get; set; }

        public double? Balance { get; set; }
    }
}
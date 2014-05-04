using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Data.Contexts;

namespace Site.ViewModel
{
    public class UserEditViewModel
    {
        [Display(Name = "Email")]
        public string Email { get; set; }

     
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Age")]
        public int? Age { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }
        
        [Display(Name = "Balance")]
        public double? Balance { get; set; }

        public void MapUser(User user)
        {
            this.Email = user.Email;
            this.Name = user.Name;
            this.Age = user.Age;
            this.Balance = user.Balance;
            this.Phone = user.Phone;
        }
    }
}
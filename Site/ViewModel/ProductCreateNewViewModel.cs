using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Models;

namespace Site.ViewModel
{
    public class ProductCreateNewViewModel
    {
        public ProductCreateNewViewModel()
        {
            Categories = new List<SelectListItem>();
        }

        [Display(Name = "Purchase Cost")]
        [DataType(DataType.Currency)]
        public double? PurchaseCost { get; set; }

        [DataType(DataType.Currency)]
        public double? Price { get; set; }

        public int? Quantity { get; set; }

        public string Name { get; set; }

        [Display(Name = "Category")]
        public int? SelectedCategoryId { get; set; }

        [Display(Name = "New Category Name")]
        public string NewCategory { get; set; }

        public List<SelectListItem> Categories { get; set; }

        public Product GetModel(IList<Category> categories)
        {
            var newProduct  = new Product()
            {
                Category = SelectedCategoryId.HasValue && SelectedCategoryId != -1 
                    ? categories.First(x => x.Id == SelectedCategoryId)
                    : null,
                Name = Name,
                Price = Price,
                PurchaseCost = PurchaseCost,
                Quantity = Quantity
            };

            if (SelectedCategoryId == -1)
            {
                newProduct.Category = new Category()
                {
                    Name = NewCategory
                };
            }

            return newProduct;
        }

        public ProductCreateNewViewModel CreateDropDowmList(IList<Category> categories)
        {
            Categories = categories.Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();

            Categories.Add(new SelectListItem()
            {
                Text = "Create new category...",
                Value = "-1"
            });

            return this;
        }
    }
}
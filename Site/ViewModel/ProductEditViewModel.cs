using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.Models;

namespace Site.ViewModel
{
    public class ProductEditViewModel : ProductCreateNewViewModel
    {
        public int Id{ get; set; }

        public void MapProduct(Product product)
        {
            this.Id = product.Id;
            this.Name = product.Name;
            this.Price = product.Price;
            this.PurchaseCost = product.PurchaseCost;
            this.Quantity = product.Quantity;
            this.SelectedCategoryId = product.CategoryId;
        }

        internal Product UpdateProduct(Product oldProduct,IList<Category> categories)
        {
            oldProduct.Name = this.Name;
            oldProduct.Price = this.Price;
            oldProduct.PurchaseCost = this.PurchaseCost;
            oldProduct.Quantity = this.Quantity;
            if (SelectedCategoryId.HasValue)
            {
                if (SelectedCategoryId != -1)
                {
                    oldProduct.Category = categories.First(x => x.Id == SelectedCategoryId);
                }
                else
                {
                    oldProduct.Category = new Category(){Name = NewCategory};
                }
            }
            return oldProduct;
        }
    }
}
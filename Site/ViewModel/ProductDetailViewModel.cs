using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.Models;

namespace Site.ViewModel
{
    public class ProductDetailViewModel : ProductCreateNewViewModel
    {
        public string Category {
            get
            {
                string currentCategory = String.Empty;
                if (this.Categories != null && this.SelectedCategoryId.HasValue)
                {
                    var item = this.Categories.FirstOrDefault(
                        category => Convert.ToInt32(category.Value) == this.SelectedCategoryId);
                    if (item != null)
                    {
                        currentCategory = item.Text;
                    }
                }
                return currentCategory;
            }
        }
        public void MapProduct(Product product)
        {
            this.Name = product.Name;
            this.Price = product.Price;
            this.PurchaseCost = product.PurchaseCost;
            this.Quantity = product.Quantity;
            this.SelectedCategoryId = product.CategoryId;
        }
    }
}
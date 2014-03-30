using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Data.Contexts;
using Domain.Models;

namespace Data.Repositories
{
    public class ProductRepository
    {
        private EntitiesContext ctx = new EntitiesContext();

        public void Add(Product product)
        {
            ctx.Products.Add(product);
            ctx.SaveChanges();
        }

        public void Update(Product product)
        {
            ctx.SaveChanges();
        }

        public void Delete(Product product)
        {
            ctx.Products.Remove(product);
            ctx.SaveChanges();
        }

        public IList<Product> GetAll()
        {
            return ctx.Products.ToList();
        }

        public IList<Product> Get(Expression<Func<Product,bool>> filter)
        {
            return ctx.Products.Where(filter).ToList();
        }

        public Product GetById(int id)
        {
            return Get(x => x.Id == id).FirstOrDefault();
        }

        public IList<Category> GetCategories()
        {
            return ctx.Categories.ToList();
        }
    }
}
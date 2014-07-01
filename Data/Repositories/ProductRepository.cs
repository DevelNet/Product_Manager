using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
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
        public IList<Product> GetByPage(int numberOfElements, int page )
        {
            int PageAll = ctx.Products.Count()/numberOfElements;
            if (page > 0 && page < PageAll)
            {
                return ctx.Products.OrderBy(x => x.Id).Skip((page - 1)*numberOfElements).Take(numberOfElements).ToList();
            }
            else
            {
                return ctx.Products.OrderBy(x => x.Id).Take(numberOfElements).ToList();
            }
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
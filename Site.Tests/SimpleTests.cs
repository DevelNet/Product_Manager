using System;
using System.Linq;
using Data.Contexts;
using Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Site.Tests
{
    [TestClass]
    public class SimpleTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            EntitiesContext stxContext = new EntitiesContext();

            stxContext.Products.Add(new Product()
            {
                Category = new Category()
                {
                    Name = "TestCategory"
                },
                Name = "TestProduct",
                PurchaseCost = 5000,
                Price = 8000,
                Quantity = 100
            });

            stxContext.SaveChanges();

            Assert.IsTrue(stxContext.Products.Any());
        }
        [TestMethod]
        public void TestMethod2()
        {
            EntitiesContext stxContext = new EntitiesContext();

            for (int i = 0; i < 100; i++)
            {
                stxContext.Products.Add(new Product()
                {
                    Category = new Category()
                    {
                        Name = "TestCategory" + i
                    },
                    Name = "TestProduct" + i,
                    PurchaseCost = 100 * i,
                    Price = 150 * i,
                    Quantity = 10*i
                });

                stxContext.SaveChanges();

                Assert.IsTrue(stxContext.Products.Any());
            }
        }
    }
}

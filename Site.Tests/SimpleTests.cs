using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Site.Models;

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
    }
}

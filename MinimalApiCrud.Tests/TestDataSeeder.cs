using CRUDwithMinimalAPI.Models;
using CRUDwithMinimalAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalApiCrud.Tests
{
    public static class TestDataSeeder
    {
        public static void SeedTestData(AppDbContext dbContext)
        {
            // Create and add sample products to the in-memory database
            var products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Price = 10.99M },
            new Product { Id = 2, Name = "Product 2", Price = 20.99M },
            // Add more sample products as needed
        };

            dbContext.Products.AddRange(products);
            dbContext.SaveChanges();
        }
    }
}



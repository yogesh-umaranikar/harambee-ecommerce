using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Infrastructure.Data
{
    public static class ProductContext
    {
        public static List<Product> products = new List<Product>();
        
        static ProductContext()
        {
            Product product;
            product = new Product
            {
                ProductID = 1,
                ProductName = "TV",
                ProductCategoryID = 1,
                Price = 6500
            };
            products.Add(product);

            product = new Product
            {
                ProductID = 2,
                ProductName = "DSTV",
                ProductCategoryID = 1,
                Price = 4000
            };
            products.Add(product);

            product = new Product
            {
                ProductID = 3,
                ProductName = "Microwave",
                ProductCategoryID = 2,
                Price = 800
            };
            products.Add(product);

            product = new Product
            {
                ProductID = 4,
                ProductName = "Gas Top",
                ProductCategoryID = 2,
                Price = 2500
            };
            products.Add(product);

            product = new Product
            {
                ProductID = 5,
                ProductName = "Washing Machine",
                ProductCategoryID = 1,
                Price = 4500
            };
            products.Add(product);
        }
    }
}

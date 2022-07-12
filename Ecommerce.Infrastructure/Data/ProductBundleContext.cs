using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Infrastructure.Data
{
    public static class ProductBundleContext
    {
        public static List<ProductBundle> productBundles = new List<ProductBundle>();
        
        static ProductBundleContext()
        {
            ProductBundle productBundle;
            productBundle = new ProductBundle
            {
                 ProductBundleID = 1,
                BundleID = 1,
                ProductID = 1

            };
            productBundles.Add(productBundle);

            productBundle = new ProductBundle
            {
                ProductBundleID = 2,
                BundleID = 1,
                ProductID = 2

            };
            productBundles.Add(productBundle);
            productBundle = new ProductBundle
            {
                ProductBundleID = 3,
                BundleID = 2,
                ProductID = 3

            };
            productBundles.Add(productBundle);
            productBundle = new ProductBundle
            {
                ProductBundleID = 4,
                BundleID = 2,
                ProductID = 4

            };
            productBundles.Add(productBundle);
        }
    }
}

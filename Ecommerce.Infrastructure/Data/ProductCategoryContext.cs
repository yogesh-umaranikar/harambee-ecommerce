using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Infrastructure.Data
{
    public static class ProductCategoryContext
    {
        public static List<ProductCategory> productCategories = new List<ProductCategory>();

        static ProductCategoryContext()
        {
            ProductCategory productCategory;
            productCategory = new ProductCategory
            {
                ProductCategoryID = 1,
                ProductCategoryName = "Electronics"

            };
            productCategories.Add(productCategory);

            productCategory = new ProductCategory
            {
                ProductCategoryID = 2,
                ProductCategoryName = "Kitchen"

            };
            productCategories.Add(productCategory);
        }
    }
}

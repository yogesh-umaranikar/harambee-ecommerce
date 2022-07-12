using Ecommerce.Core.Entities;
using Ecommerce.Core.Repositories;
using Ecommerce.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            return ProductContext.products;
        }

        public List<Product> GetProductsByCategory(int categoryID)
        {
            return ProductContext.products.Where(a => a.ProductCategoryID == categoryID).ToList();
        }
    }
}

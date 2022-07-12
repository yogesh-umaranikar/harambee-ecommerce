using System;
using System.Collections.Generic;
using System.Text;
using Ecommerce.Core.Entities;
using Ecommerce.Core.Repositories;

namespace Ecommerce.Core.Repositories
{
    public interface IProductRepository
    {
        //custom operations here
        public List<Product> GetAllProducts();

        public List<Product> GetProductsByCategory(int categoryID);

        // get product by id
    }
}

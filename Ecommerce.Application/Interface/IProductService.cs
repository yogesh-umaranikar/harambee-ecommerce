using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Interface
{
    public interface IProductService
    {
        public List<Product> GetAllProducts();

        public List<Product> GetProductsByCategory(int categoryID);


    }
}

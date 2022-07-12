using Ecommerce.Application.Interface;
using Ecommerce.Core.Entities;
using Ecommerce.Core.Repositories;
using System;
using System.Collections.Generic;

namespace Ecommerce.Application
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public List<Product> GetAllProducts()
        {
            return this.productRepository.GetAllProducts();
        }

        public List<Product> GetProductsByCategory(int categoryID)
        {
           return this.productRepository.GetProductsByCategory(categoryID);
        }
    }
}

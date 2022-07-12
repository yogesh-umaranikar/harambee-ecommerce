using Ecommerce.Application.Interface;
using Ecommerce.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet(Name = "GetAllProducts")]
        public List<Product> GetAllProducts()
        {
            return this.productService.GetAllProducts();
        }

        [HttpGet("{categoryID}")]
        public List<Product> GetProductsByCategoryID(int categoryID)
        {
            return this.productService.GetProductsByCategory(categoryID);
        }
    }
}

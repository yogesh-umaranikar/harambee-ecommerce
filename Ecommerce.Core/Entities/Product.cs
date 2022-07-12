using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductCategoryID { get; set; }
        public double Price { get; set; }
    }
}

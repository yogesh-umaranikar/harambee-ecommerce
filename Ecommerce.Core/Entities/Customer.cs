using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobile { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.Entities
{
    public class Basket
    {
        public int BasketID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int ProductBundleID { get; set; }
        public string BasketDescription { get; set; }
        public double BasketPrice { get; set; }
    }
}

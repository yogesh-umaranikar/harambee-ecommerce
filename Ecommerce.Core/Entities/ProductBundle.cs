using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.Entities
{
    public class ProductBundle
    {
        public int ProductBundleID { get; set; }
        public int ProductID { get; set; }
        public int BundleID { get; set; }
    }
}

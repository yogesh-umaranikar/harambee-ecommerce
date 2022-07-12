using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.Entities
{
    public class Bundle
    {
        public int BundleID { get; set; }
        public string BundleName { get; set; }
        public double BundlePrice { get; set; }
    }
}

using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Infrastructure.Data
{
    public static class BundleContext
    {
        public static List<Bundle> bundles = new List<Bundle>();
        
        static BundleContext()
        {
            Bundle bundle;
            bundle = new Bundle
            {
                BundleID = 1,
                BundleName = "Entertainment",
                BundlePrice = 4000

            };
            bundles.Add(bundle);

            bundle = new Bundle
            {
                BundleID = 2,
                BundleName = "Kitchen",
                BundlePrice = 5800

            };
            bundles.Add(bundle);
        }
    }
}

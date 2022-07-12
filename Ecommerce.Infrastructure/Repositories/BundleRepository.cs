using Ecommerce.Core.Entities;
using Ecommerce.Core.Repositories;
using Ecommerce.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Repositories
{
    public class BundleRepository : IBundleRepository
    {
        public List<Bundle> GetBundles()
        {
            return BundleContext.bundles;
        }
    }
}

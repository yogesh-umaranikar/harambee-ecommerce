using Ecommerce.Application.Interface;
using Ecommerce.Core.Entities;
using Ecommerce.Core.Repositories;
using System;
using System.Collections.Generic;

namespace Ecommerce.Application
{
    public class BundleService : IBundleService
    {
        private readonly IBundleRepository bundleRepository;
        public BundleService(IBundleRepository bundleRepository)
        {
            this.bundleRepository = bundleRepository;
        }

        public List<Bundle> GetBundles()
        {
            return this.bundleRepository.GetBundles();
        }
    }
}

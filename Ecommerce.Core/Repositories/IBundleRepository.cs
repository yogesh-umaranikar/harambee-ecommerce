﻿using System;
using System.Collections.Generic;
using System.Text;
using Ecommerce.Core.Entities;
using Ecommerce.Core.Repositories;

namespace Ecommerce.Core.Repositories
{
    public interface IBundleRepository
    {
        //custom operations here
        public List<Bundle> GetBundles();
    }
}

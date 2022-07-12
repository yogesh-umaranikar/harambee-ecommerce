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
    public class BundleController : ControllerBase
    {
        private readonly IBundleService bundleService;
        public BundleController(IBundleService bundleService)
        {
            this.bundleService = bundleService;
        }

        [HttpGet(Name = "GetBundles")]
        public List<Bundle> GetBundles()
        {
            return this.bundleService.GetBundles();
        }
    }
}

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
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;
        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet(Name = "GetCustomerByID")]
        public Customer GetCustomerByID(int id)
        {
           return this.customerService.GetCustomerByID(id);
        }
    }
}

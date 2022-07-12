using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Interface
{
    public interface ICustomerService
    {
        public Customer GetCustomerByID(int id);
            
    }
}

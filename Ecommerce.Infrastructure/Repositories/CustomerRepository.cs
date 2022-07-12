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
    public class CustomerRepository : ICustomerRepository
    {
        public Customer GetCustomerByID(int custID)
        {
            return CustomerContext.customers.Where(a => a.CustomerID == custID).FirstOrDefault();
        }
    }
}

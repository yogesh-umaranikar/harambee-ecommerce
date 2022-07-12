using Ecommerce.Application.Interface;
using Ecommerce.Core.Entities;
using Ecommerce.Core.Repositories;
using System;

namespace Ecommerce.Application
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public Customer GetCustomerByID(int id)
        {
            return this.customerRepository.GetCustomerByID(id);
        }
    }
}

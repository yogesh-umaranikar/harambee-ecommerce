using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Infrastructure.Data
{

    public static class CustomerContext
    {
        public static List<Customer> customers = new List<Customer>();
        static CustomerContext()
        {
            Customer customer;
            customer = new Customer
            {
                CustomerID = 1,
                CustomerName = "Hanile",
                CustomerEmail = "hanile@harambee.co.za",
                CustomerMobile = "4534534544",
            };
            customers.Add(customer);
            customer = new Customer
            {
                CustomerID = 2,
                CustomerName = "Rigard",
                CustomerEmail = "rigard@harambee.co.za",
                CustomerMobile = "345345455",
            };
            customers.Add(customer);
            customer = new Customer
            {
                CustomerID = 3,
                CustomerName = "Kasmeer",
                CustomerEmail = "kasmeer@harambee.co.za",
                CustomerMobile = "887653233",
            };
            customers.Add(customer);
        }
         

        
    }
}

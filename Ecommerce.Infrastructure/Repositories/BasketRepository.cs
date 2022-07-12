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
    public class BasketRepository : IBasketRepository
    {
        public Basket AddToBasket(Basket basket)
        {
            BasketContext.basket.Add(basket);
            return basket;
        }

        public Basket GetBasket(int customerID)
        {
            return BasketContext.basket.Where(a => a.CustomerID == customerID).FirstOrDefault();
        }

        public double GetBasketValue(int basketID)
        {
            return BasketContext.basket.Sum(a => a.BasketPrice);
        }
    }
}

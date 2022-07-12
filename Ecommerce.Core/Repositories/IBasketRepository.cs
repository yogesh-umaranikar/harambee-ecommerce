using System;
using System.Collections.Generic;
using System.Text;
using Ecommerce.Core.Entities;
using Ecommerce.Core.Repositories;

namespace Ecommerce.Core.Repositories
{
    public interface IBasketRepository
    {
        public Basket GetBasket(int customerID);

        public double GetBasketValue(int basketID);

        public Basket AddToBasket(Basket basket);
    }
}

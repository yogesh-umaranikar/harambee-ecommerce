using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Interface
{
    public interface IBasketService
    {
        public Basket AddToBasket(Basket basket);

        public Basket GetBasket(int customerID);

        public double GetBasketValue(int basketID);

    }
}

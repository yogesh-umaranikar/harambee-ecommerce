using Ecommerce.Application.Interface;
using Ecommerce.Core.Entities;
using Ecommerce.Core.Repositories;
using System;

namespace Ecommerce.Application
{
    public class BasketService : IBasketService
    {
        private readonly IBasketRepository basketRepository;
        private readonly IProductRepository productRepository;
        //private readonly IBundleRepository bundleRepository;

        public BasketService(IBasketRepository basketRepository)
        {
            this.basketRepository = basketRepository;
        }

        public Basket AddToBasket(Basket basket)
        {
            //var productDetails = this.productRepository.GetProductsByID(basket.ProductID);

            return this.basketRepository.AddToBasket(basket);
        }

        public Basket GetBasket(int customerID)
        {
            return this.basketRepository.GetBasket(customerID);
        }

        public double GetBasketValue(int basketID)
        {
            return this.basketRepository.GetBasketValue(basketID);
        }
    }
}

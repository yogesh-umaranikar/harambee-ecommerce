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
    public class BasketController : ControllerBase
    {
        private readonly IBasketService basketService;
        public BasketController(IBasketService basketService)
        {
            this.basketService = basketService;
        }

        [HttpGet]
        public Basket GetBasketByCustomerID(int customerID)
        {
           return this.basketService.GetBasket(customerID);
        }

        [HttpPost]
        public Basket AddToBasket([FromBody]Basket basket)
        {
            return this.basketService.AddToBasket(basket);
        }

        [HttpGet("GetBasketValue")]
        public double GetBasketValue(int basketID)
        {
            return this.basketService.GetBasketValue(basketID);
        }
    }
}

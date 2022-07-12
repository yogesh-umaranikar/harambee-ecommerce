using Ecommerce.Application;
using Ecommerce.Application.Interface;
using Ecommerce.Core.Repositories;
using Ecommerce.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Ecommerce.IOC
{
    public static class RegisterComponent
    {
        public static void RegisterDependency(this IServiceCollection services)
        {
            //Service Layer
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IBundleService, BundleService>();

            //Repository Layer
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();         
            services.AddScoped<IBasketRepository, BasketRepository>();
            services.AddScoped<IBundleRepository, BundleRepository>();

        }
    }
}

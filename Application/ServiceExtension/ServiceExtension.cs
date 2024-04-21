using Microsoft.EntityFrameworkCore;
 
using Test.Domain.Interfaces;
using Test.Infrastructure.DataBase;
using Test.Infrastructure.Repository;

namespace Test.Application.ServiceExtension
{
    public static class ServiceExtension
    {
        
            public static IServiceCollection AddDIServices(this IServiceCollection services, IConfiguration configuration)
            {
                services.AddDbContext<EcomerceDbContext>(options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("Ecommerce"));
                });
                services.AddScoped<IUnitOfWork, UnitOfWork>();
                services.AddScoped<IProductRepository, productRepository>();
            services.AddScoped<IOrderRepository, orderRepository>();
            return services;
             
        }
    }
}

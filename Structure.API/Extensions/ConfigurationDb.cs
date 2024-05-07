using Structure.Domain.Interfaces.Repository;
using Structure.Infrastructure.Repository;
using Structure.Infrastructure.Repository.CompanyRepository;
using Structure.Infrastructure.Services;
using System.Runtime.CompilerServices;

namespace Structure.API.Extensions
{
    public static class ConfigurationDb
    {
        public static IServiceCollection Repositoryconfig(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }

        public static IServiceCollection Serviceconfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICompanyservice, Companyservice>();
            return services;
        }
    }
}

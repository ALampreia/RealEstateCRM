using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealEstateCRM.Data;
using RealEstateCRM.Domain.Interfaces;

namespace RealEstateCRM.IoC
{
    public static class DependencyInjection
    {
        public static void AddServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddApplicationServices();
            services.AddData(config);
        }
    }
}

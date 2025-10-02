using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealEstateCRM.Data;
using RealEstateCRM.Domain.Interfaces;
using RealEstateCRM.Services.Properties;
using RealEstateCRM.Services.Users;

namespace RealEstateCRM.IoC
{
    public static class DependencyInjection
    {
        public static void AddServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddApplicationServices();
            services.AddData(config);
            services.AddAutoMapper(typeof(UserProfile).Assembly, typeof(PropertyProfile).Assembly);
        }
    }
}

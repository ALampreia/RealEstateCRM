using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealEstateCRM.Services;
using RealEstateCRM.Data;
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
            services.AddAutoMapper(cfg => { }, typeof(UserProfile).Assembly);
            services.AddAutoMapper(cfg => { }, typeof(PropertyProfile).Assembly);

        }
    }
}

using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using RealEstateCRM.Services.Properties;
using RealEstateCRM.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblyContaining<RegisterUserCommandHandler>();                
                cfg.RegisterServicesFromAssemblyContaining<RegisterPropertyCommandHandler>();
            });

            services.AddValidatorsFromAssemblyContaining<RegisterUserCommandValidator>();
            services.AddValidatorsFromAssemblyContaining<RegisterPropertyCommandValidator>();

            return services;
        }
    }
}

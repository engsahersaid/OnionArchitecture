using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Services.Abstractions;
using OnionArchitecture.Services.Services;

namespace OnionArchitecture.Services
{
    public static class ServiceRegisteration
    {
        public static IServiceCollection AddServicesRegisteration(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();

            return services;
        }
    }
}
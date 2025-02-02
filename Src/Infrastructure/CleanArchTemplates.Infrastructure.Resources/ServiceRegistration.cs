using CleanArchTemplates.Application.Interfaces;
using CleanArchTemplates.Infrastructure.Resources.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchTemplates.Infrastructure.Resources
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddResourcesInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<ITranslator, Translator>();

            return services;
        }
    }
}

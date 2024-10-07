using CleanArchTemplates.Application.Interfaces;
using CleanArchTemplates.Infrastructure.FileManager.Contexts;
using CleanArchTemplates.Infrastructure.FileManager.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchTemplates.Infrastructure.FileManager
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddFileManagerInfrastructure(this IServiceCollection services, IConfiguration configuration, bool useInMemoryDatabase)
        {
            if (useInMemoryDatabase)
            {
                services.AddDbContext<FileManagerDbContext>(options =>
                    options.UseInMemoryDatabase(nameof(FileManagerDbContext)));
            }
            else
            {
                services.AddDbContext<FileManagerDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("FileManagerConnection")));
            }

            services.AddScoped<IFileManagerService, FileManagerService>();

            return services;
        }
    }
}

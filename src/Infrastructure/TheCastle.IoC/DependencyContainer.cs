using Microsoft.Extensions.DependencyInjection;
using TheCastle.Application.Interfaces;
using TheCastle.Application.Services;
using TheCastle.Data.Repositories;
using TheCastle.Domain.Interfaces;

namespace CleanArchitectureDemo.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddScoped<IArmyService, ArmyService>();
            services.AddScoped<ICastleService, CastleService>();

            // Domain.Interfaces | Data.Repositories
            services.AddScoped<IArmyRepository, ArmyRepository>();
            services.AddScoped<ICastleRepository, CastleRepository>();
        }
    }
}

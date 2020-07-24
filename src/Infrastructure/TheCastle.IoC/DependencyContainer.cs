using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureDemo.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // CleanArchitecture.Application
            //services.AddScoped<IBookService, BookService>();

            // CleanArchitecture.Domain.Interfaces | CleanArchitecture.Infra.Data.Repositories
            //services.AddScoped<IBookRepository, BookRepository>();
        }
    }
}

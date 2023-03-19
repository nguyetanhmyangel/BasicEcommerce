using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace BasicEcommerce.Infrastructure.Extensions;

public class RegisterServiceCollections
{
    public static void RegisterInfrastructureMappings(IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }

    // public static IServiceCollection RegisterInfrastructureRepositories(IServiceCollection services)
    // {
    //     return services
    //         .AddTransient(typeof(IRepositoryAsync<,>), typeof(RepositoryAsync<,>))
    //         .AddTransient<IProductRepository, ProductRepository>()
    //         .AddTransient<IBrandRepository, BrandRepository>()
    //         .AddTransient<IDocumentRepository, DocumentRepository>()
    //         .AddTransient<IDocumentTypeRepository, DocumentTypeRepository>()
    //         .AddTransient(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
    // }
}
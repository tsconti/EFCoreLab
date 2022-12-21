using Microsoft.Extensions.DependencyInjection;

namespace EFCoreLab.GenericRepository;

public static class RepositoryServicesDI
{
    public static IServiceCollection AddPersonalFrameworkDatabaseRepositoryServices(this IServiceCollection services, Type modelMapping)
    {
        services.AddScoped(typeof(IDbRepository<>), typeof(RepositoryBase<>));
        services.AddSingleton(typeof(IModelMapping), modelMapping);

        services.AddScoped<DataContext>(serviceProvider =>
        {
            var dbConnectionConfig = serviceProvider.GetRequiredService<IDbConnectionConfig>();
            var modelMapping = serviceProvider.GetRequiredService<IModelMapping>();

            return new DataContext(dbConnectionConfig, modelMapping);
        });

        return services;
    }
}

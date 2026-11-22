using Microsoft.EntityFrameworkCore;
using purpura_inventory.Infrastructure.Persistence;

namespace purpura_inventory.Infrastructure.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddIdentityService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContextPool<InventoryContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        return services;
    }
}
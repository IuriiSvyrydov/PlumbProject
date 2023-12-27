using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepositoryLayer.Context;

namespace RepositoryLayer.Extensions;

public static class RepositoryLayerExtensions
{
    public static IServiceCollection AddDbConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(x =>
            x.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        return services;
    }
}
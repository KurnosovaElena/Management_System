using DAL.Constants;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.DI;

public static class ServicesConfguration
{
    public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ManagementSystemDBContext>(options => options.UseNpgsql(configuration.GetConnectionString(Connections.DBConnection)));
    }
}
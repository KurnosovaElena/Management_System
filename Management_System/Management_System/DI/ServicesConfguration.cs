using ManagementSystem.Context;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.DI
{
    public static class ServicesConfguration
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ManagementSystemDBContext>(options => options.UseNpgsql(configuration.GetConnectionString("DBConnection")));
        }
    }
}

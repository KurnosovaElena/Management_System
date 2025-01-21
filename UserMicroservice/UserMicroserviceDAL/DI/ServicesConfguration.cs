using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserMicroserviceDAL.Constants;
using UserMicroserviceDAL.Context;
using UserMicroserviceDAL.Repositories.Implementations;
using UserMicroserviceDAL.Repositories.Interfaces;

namespace UserMicroserviceDAL.DI;

public static class ServicesConfguration
{
    public static void AddDataAccessDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<UserMicriserviceDBContext>(options => options.UseNpgsql(configuration.GetConnectionString(Connections.DBConnection)));

        services.AddScoped<IUsersRepository, UsersRepository>();
    }
}

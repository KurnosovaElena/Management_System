using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserMicroserviceBLL.Profiles;
using UserMicroserviceBLL.Services.Implementations;
using UserMicroserviceBLL.Services.Interfaces;
using UserMicroserviceDAL.DI;

namespace UserMicroserviceBLL.DI;

public static class ServicesConfguration
{
    public static void AddBusinessLogicDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDataAccessDependencies(configuration);

        services.AddScoped<IUserService, UserService>();

        services.AddAutoMapper(typeof(UserMicroserviceProfiles));
    }
}

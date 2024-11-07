using BLL.DI;

namespace ManagementSystem.DI;

public static class ServicesConfguration
{
    public static void AddApiDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddBusinessLogicDependencies(configuration);
    }
}
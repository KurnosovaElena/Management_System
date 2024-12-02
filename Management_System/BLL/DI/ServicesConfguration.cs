using BLL.Services.Implementaiton;
using BLL.Services.Interfaсes;
using DAL.DI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BLL.Profiles;
using BLL.Services.Implementation;
using BLL.Services.Interfaces;

namespace BLL.DI;

public static class ServicesConfguration
{
    public static void AddBusinessLogicDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDataAccessDependencies(configuration);

        services.AddScoped<IBoardService, BoardService>();
        services.AddScoped<ITaskStatusService, TaskStatusService>();
        services.AddScoped<ILabelService, LabelService>();

        services.AddAutoMapper(typeof(BoardProfile));
    }
}

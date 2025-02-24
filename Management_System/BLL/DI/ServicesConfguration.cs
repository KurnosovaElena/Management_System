using BLL.Profiles;
using BLL.Services.Implementation;
using BLL.Services.Interfaces;
using BLL.Services.Interfaсes;
using DAL.DI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.DI;

public static class ServicesConfguration
{
    public static void AddBusinessLogicDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDataAccessDependencies(configuration);

        services.AddScoped<IBoardService, BoardService>();
        services.AddScoped<ITaskStatusService, TaskStatusService>();
        services.AddScoped<ILabelService, LabelService>();
        services.AddScoped<ITasksService, TasksService>();
        services.AddScoped<ISubtaskService, SubtaskService>();
        services.AddScoped<IUserBoardService, UserBoardService>();
        services.AddScoped<IUserTaskService, UserTaskService>();

        services.AddAutoMapper(typeof(ManagementSystemProfiles));
    }
}
using DAL.Constants;
using DAL.Context;
using DAL.Repositories.Implementations;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.DI;

public static class ServicesConfguration
{
    public static void AddDataAccessDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ManagementSystemDBContext>(options => options.UseNpgsql(configuration.GetConnectionString(Connections.DBConnection)));

        services.AddScoped<IBoardRepository, BoardRepository>();
        services.AddScoped<ITaskStatusRepository, TaskStatusRepository>();
        services.AddScoped<ILabelRepository, LabelRepository>();
        services.AddScoped<ITaskRepository, TaskRepository>();
        services.AddScoped<ISubtaskRepository, SubtaskRepository>();
        services.AddScoped<IUserBoardRepository, UserBoardRepository>();
        services.AddScoped<IUserTaskRepository, UserTaskRepository>();
    }
}
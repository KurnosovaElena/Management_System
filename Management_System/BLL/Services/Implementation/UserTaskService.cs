using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Exceptions;
using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementation;

public class UserTaskService(IUserTaskRepository repository, IMapper mapper) : IUserTaskService
{
    public async Task<UserTaskDto> Add(CreateUserTaskDto entity, Guid userId, Guid taskId, CancellationToken cancellationToken)
    {
        var userTask = mapper.Map<UserTaskEntity>(entity);
        userTask.UserId = userId;
        userTask.TaskId = taskId;

        await repository.Add(userTask, cancellationToken);
        var userTaskDTO = mapper.Map<UserTaskDto>(userTask);

        return userTaskDTO;
    }

    public async Task<UserTaskDto> GetByUserIdAndTaskIdAsync(Guid userId, Guid taskId, CancellationToken cancellationToken)
    {
        var userTaskEntity = await repository.GetByUserIdAndTaskIdAsync(userId, taskId, cancellationToken);

        return userTaskEntity == null
            ? throw new NotFoundException("No user task found") : mapper.Map<UserTaskDto>(userTaskEntity);
    }

    public async Task<IEnumerable<UserTaskDto>> GetTasksByUserIdAsync(Guid userId, CancellationToken cancellationToken)
    {
        var userTaskEntities = await repository.GetTasksByUserIdAsync(userId, cancellationToken);
        return mapper.Map<IEnumerable<UserTaskDto>>(userTaskEntities);
    }

    public async Task<IEnumerable<UserTaskDto>> GetUsersByTaskIdAsync(Guid taskId, CancellationToken cancellationToken)
    {
        var userTaskEntities = await repository.GetUsersByTaskIdAsync(taskId, cancellationToken);
        return mapper.Map<IEnumerable<UserTaskDto>>(userTaskEntities);
    }

    public async Task<IEnumerable<UserTaskDto>> GetAll(CancellationToken cancellationToken)
    {
        var usersTasks = await repository.GetAll(cancellationToken);

        var usersTasksDTO = mapper.Map<IEnumerable<UserTaskDto>>(usersTasks);

        return usersTasksDTO;
    }

    public async Task<UserTaskDto> Update(Guid userId, Guid taskId, CreateUserTaskDto entity, CancellationToken cancellationToken)
    {
        var userTask = await repository.GetByUserIdAndTaskIdAsync(userId, taskId, cancellationToken)
            ?? throw new NotFoundException("UserTask not found");
        mapper.Map(entity, userTask);
        await repository.Update(userTask, cancellationToken);
        var userTaskDTO = mapper.Map<UserTaskDto>(userTask);

        return userTaskDTO;
    }

    public async Task Delete(Guid userId, Guid taskId, CancellationToken cancellationToken)
    {
        var userTask = await repository.GetByUserIdAndTaskIdAsync(userId, taskId, cancellationToken)
            ?? throw new NotFoundException("UserTask not found");
        await repository.Delete(userTask, cancellationToken);
    }
}

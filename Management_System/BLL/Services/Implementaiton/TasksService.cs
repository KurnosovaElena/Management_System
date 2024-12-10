using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementaiton;

public class TasksService(ITaskRepository repository, IMapper mapper) : ITasksService
{
    public async Task<TasksDTO> Add(CreateTasksDTO entity, CancellationToken cancellationToken)
    {
        var task = mapper.Map<TaskEntity>(entity);

        await repository.Add(task, cancellationToken);

        var taskDTO = mapper.Map<TasksDTO>(task);

        return taskDTO;
    }

    public async Task<TasksDTO> GetById(Guid id, CancellationToken cancellationToken)
    {
        var task = await repository.GetById(id, cancellationToken);

        var taskDTO = mapper.Map<TasksDTO>(task);

        return taskDTO;
    }

    public async Task<IEnumerable<TasksDTO>> GetAll(CancellationToken cancellationToken)
    {
        var tasks = await repository.GetAll(cancellationToken);

        var tasksDTO = mapper.Map<IEnumerable<TasksDTO>>(tasks);

        return tasksDTO;
    }

    public async Task<TasksDTO> Update(Guid id, CreateTasksDTO entity, CancellationToken cancellationToken)
    {
        var task = await repository.GetById(id, cancellationToken);

        mapper.Map(entity, task);

        await repository.Update(task, cancellationToken);

        var taskDTO = mapper.Map<TasksDTO>(task);

        return taskDTO;
    }


    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var task = await repository.GetById(id, cancellationToken);
        await repository.Delete(task, cancellationToken);
    }
}

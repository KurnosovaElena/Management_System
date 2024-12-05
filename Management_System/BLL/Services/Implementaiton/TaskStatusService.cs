using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using BLL.DTO.CreateDTO;
using BLL.DTO;
using AutoMapper;

namespace BLL.Services.Implementaiton;

public class TaskStatusService(ITaskStatusRepository repository, IMapper mapper) : ITaskStatusService
{
    public async Task<TaskStatusDTO> Add(CreateTaskStatusDTO entity, CancellationToken cancellationToken)
    {
        var taskStatus = mapper.Map<TaskStatusEntity>(entity);

        await repository.Add(taskStatus, cancellationToken);

        var taskStatusDTO = mapper.Map<TaskStatusDTO>(taskStatus);

        return taskStatusDTO;
    }

    public async Task<TaskStatusDTO> GetById(Guid id, CancellationToken cancellationToken)
    {
        var taskStatus = await repository.GetById(id, cancellationToken);

        var taskStatusDTO = mapper.Map<TaskStatusDTO>(taskStatus);

        return taskStatusDTO;
    }

    public async Task<IEnumerable<TaskStatusDTO>> GetAll(CancellationToken cancellationToken)
    {
        var statusAll = await repository.GetAll(cancellationToken);

        var statusAllDTO = mapper.Map<IEnumerable<TaskStatusDTO>>(statusAll);

        return statusAllDTO;
    }

    public async Task<TaskStatusDTO> Update(Guid id, CreateTaskStatusDTO entity, CancellationToken cancellationToken)
    {
        var status = await repository.GetById(id, cancellationToken);

        mapper.Map(entity, status);

        await repository.Update(status, cancellationToken);

        var statusDTO = mapper.Map<TaskStatusDTO>(status);

        return statusDTO;
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var status = await repository.GetById(id, cancellationToken);

        await repository.Delete(status, cancellationToken);
    }
}
using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Exceptions;
using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementation;

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
        var taskStatus = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No task status found");

        var taskStatusDTO = mapper.Map<TaskStatusDTO>(taskStatus);

        return taskStatusDTO;
    }

    public async Task<IEnumerable<TaskStatusDTO>> GetAll(CancellationToken cancellationToken)
    {
        var statusAll = await repository.GetAll(cancellationToken)
            ?? throw new NotFoundException("No task statuses found");

        var statusAllDTO = mapper.Map<IEnumerable<TaskStatusDTO>>(statusAll);

        return statusAllDTO;
    }

    public async Task<TaskStatusDTO> Update(Guid id, CreateTaskStatusDTO entity, CancellationToken cancellationToken)
    {
        if (entity is null)
        {
            throw new BadRequestException("Invalid task status data provided.");
        }

        var status = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No task status found");

        mapper.Map(entity, status);

        await repository.Update(status, cancellationToken);

        var statusDTO = mapper.Map<TaskStatusDTO>(status);

        return statusDTO;
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var status = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No task status found");

        await repository.Delete(status, cancellationToken);
    }
}
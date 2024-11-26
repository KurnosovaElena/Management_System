using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementaiton;

public class TaskStatusService(ITaskStatusRepository repository) : ITaskStatusService
{
    public async Task<TaskStatusEntity> Add(TaskStatusEntity entity, CancellationToken cancellationToken)
    {
        await repository.Add(entity, cancellationToken);

        return entity;
    }

    public async Task<TaskStatusEntity> GetById(Guid id, CancellationToken cancellationToken)
    {
        var status = await repository.GetById(id, cancellationToken);

        return status;
    }

    public async Task<IEnumerable<TaskStatusEntity>> GetAll(CancellationToken cancellationToken)
    {
        var statusAll = await repository.GetAll(cancellationToken);
        return statusAll;
    }

    public async Task<TaskStatusEntity> Update(Guid id, TaskStatusEntity entity, CancellationToken cancellationToken)
    {
        var status = await repository.GetById(id, cancellationToken);

        await repository.Update(status, cancellationToken);

        return status;
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var status = await repository.GetById(id, cancellationToken);

        await repository.Delete(status, cancellationToken);
    }
}

using DAL.Entities;

namespace BLL.Services.Interfaсes;

public interface ITaskStatusService
{
    Task<TaskStatusEntity> GetById(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<TaskStatusEntity>> GetAll(CancellationToken cancellationToken);
    Task<TaskStatusEntity> Add(TaskStatusEntity entity, CancellationToken cancellationToken);
    Task<TaskStatusEntity> Update(Guid id, TaskStatusEntity entity, CancellationToken cancellationToken);
    Task Delete(Guid id, CancellationToken cancellationToken);
}
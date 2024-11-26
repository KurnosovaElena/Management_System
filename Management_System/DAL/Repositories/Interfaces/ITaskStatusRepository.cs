using DAL.Entities;

namespace DAL.Repositories.Interfaces;

public interface ITaskStatusRepository : IRepository<TaskStatusEntity>
{
    Task<TaskStatusEntity> GetById(Guid id, CancellationToken cancellationToken);
}
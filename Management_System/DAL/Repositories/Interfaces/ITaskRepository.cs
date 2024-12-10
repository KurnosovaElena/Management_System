using DAL.Entities;

namespace DAL.Repositories.Interfaces
{
    public interface ITaskRepository : IRepository<TaskEntity>
    {
        Task<TaskEntity> GetById(Guid id, CancellationToken cancellationToken);
    }
}

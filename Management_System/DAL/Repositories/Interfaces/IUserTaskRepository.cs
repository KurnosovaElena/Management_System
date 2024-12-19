using DAL.Entities;

namespace DAL.Repositories.Interfaces;

public interface IUserTaskRepository : IRepository<UserTaskEntity>
{
    Task<UserTaskEntity?> GetByUserIdAndTaskIdAsync(Guid userId, Guid boardId, CancellationToken cancellationToken);
    Task<IEnumerable<UserTaskEntity>> GetTasksByUserIdAsync(Guid userId, CancellationToken cancellationToken);
    Task<IEnumerable<UserTaskEntity>> GetUsersByTaskIdAsync(Guid boardId, CancellationToken cancellationToken);
}

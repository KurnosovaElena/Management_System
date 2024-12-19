using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class UserTaskRepository(ManagementSystemDBContext db) : Repository<UserTaskEntity>(db), IUserTaskRepository
{
    public async Task<UserTaskEntity?> GetByUserIdAndTaskIdAsync(Guid userId, Guid taskId, CancellationToken cancellationToken)
    {
        return await db.Set<UserTaskEntity>()
            .Include(ub => ub.User)
            .Include(ub => ub.Task)
            .AsNoTracking()
            .FirstOrDefaultAsync(entity => entity.UserId == userId && entity.TaskId == taskId, cancellationToken);
    }

    public async Task<IEnumerable<UserTaskEntity>> GetTasksByUserIdAsync(Guid userId, CancellationToken cancellationToken)
    {
        return await db.Set<UserTaskEntity>()
            .Include(ub => ub.Task)
            .Where(ub => ub.UserId == userId)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<UserTaskEntity>> GetUsersByTaskIdAsync(Guid taskId, CancellationToken cancellationToken)
    {
        return await db.Set<UserTaskEntity>()
            .Include(ub => ub.User)
            .Where(ub => ub.TaskId == taskId)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }
}

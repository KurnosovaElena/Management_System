using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class TaskRepository(ManagementSystemDBContext db) : Repository<TaskEntity>(db), ITaskRepository
{
    public override async Task<TaskEntity?> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await db.Set<TaskEntity>()
            .Include(b => b.Subtasks)
            .AsNoTracking()
            .FirstOrDefaultAsync(entity => entity.Id == id, cancellationToken);
    }
}
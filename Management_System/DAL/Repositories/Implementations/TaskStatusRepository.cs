using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class TaskStatusRepository(ManagementSystemDBContext db) : Repository<TaskStatusEntity>(db), ITaskStatusRepository
{
    public override async Task<TaskStatusEntity?> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await db.Set<TaskStatusEntity>()
        .Include(b => b.Tasks)
        .AsNoTracking()
        .FirstOrDefaultAsync(entity => entity.Id == id, cancellationToken);
    }
}
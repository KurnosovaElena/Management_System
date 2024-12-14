using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class SubtaskRepository(ManagementSystemDBContext db) : Repository<SubtaskEntity>(db), ISubtaskRepository
{
    public override async Task<SubtaskEntity?> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await db.Set<SubtaskEntity>()
            .AsNoTracking()
            .FirstOrDefaultAsync(entity => entity.Id == id, cancellationToken);
    }
}

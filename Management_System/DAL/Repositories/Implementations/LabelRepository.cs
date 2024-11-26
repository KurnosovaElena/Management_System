using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class LabelRepository(ManagementSystemDBContext db) : Repository<LabelEntity>(db), ILabelRepository
{
    public override async Task<LabelEntity?> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await db.Set<LabelEntity>()
        .Include(b => b.Tasks)
        .AsNoTracking()
        .FirstOrDefaultAsync(entity => entity.Id == id, cancellationToken);
    }
}
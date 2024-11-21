using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class LabelRepository(ManagementSystemDBContext db) : Repository<LabelEntity>(db), ILabelRepository
{
    public async Task<LabelEntity?> GetLabel(Guid id, CancellationToken cancellationToken)
    {
        var label = await GetById(id)
            .Include(b => b.Tasks)
            .FirstOrDefaultAsync(cancellationToken);
        return label;
    }
}
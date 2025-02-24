using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class BoardRepository(ManagementSystemDBContext db) : Repository<BoardEntity>(db), IBoardRepository
{
    public override async Task<BoardEntity?> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await db.Set<BoardEntity>()
            .Include(b => b.TaskStatus)
            .AsNoTracking()
            .FirstOrDefaultAsync(entity => entity.Id == id, cancellationToken);
    }
}
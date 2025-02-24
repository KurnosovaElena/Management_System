using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class UserBoardRepository(ManagementSystemDBContext db) : Repository<UserBoardEntity>(db), IUserBoardRepository
{
    public async Task<UserBoardEntity?> GetByUserIdAndBoardIdAsync(Guid userId, Guid boardId, CancellationToken cancellationToken)
    {
        return await db.Set<UserBoardEntity>()
            .Include(ub => ub.Board)
            .AsNoTracking()
            .FirstOrDefaultAsync(entity => entity.UserId == userId && entity.BoardId == boardId, cancellationToken);
    }

    public async Task<IEnumerable<UserBoardEntity>> GetBoardsByUserIdAsync(Guid userId, CancellationToken cancellationToken)
    {
        return await db.Set<UserBoardEntity>()
            .Include(ub => ub.Board)
            .Where(ub => ub.UserId == userId)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<UserBoardEntity>> GetUsersByBoardIdAsync(Guid boardId, CancellationToken cancellationToken)
    {
        return await db.Set<UserBoardEntity>()
            .Where(ub => ub.BoardId == boardId)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }
}

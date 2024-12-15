using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class UserRepository(ManagementSystemDBContext db) : Repository<UserEntity>(db), IUserRepository
{
    public override async Task<UserEntity?> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await db.Set<UserEntity>()
        .Include(b => b.UserBoards)
        .Include(b => b.UserTasks)
        .AsNoTracking()
        .FirstOrDefaultAsync(entity => entity.Id == id, cancellationToken);
    }
}
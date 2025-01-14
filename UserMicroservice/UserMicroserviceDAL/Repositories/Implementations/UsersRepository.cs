using Microsoft.EntityFrameworkCore;
using UserMicroserviceDAL.Context;
using UserMicroserviceDAL.Entities;
using UserMicroserviceDAL.Repositories.Interfaces;

namespace UserMicroserviceDAL.Repositories.Implementations;

public class UsersRepository(UserMicriserviceDBContext db) : Repository<UserEntity>(db), IUsersRepository
{
    public override async Task<UserEntity?> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await db.Set<UserEntity>()
        //.Include(b => b.UserBoards)
        //.Include(b => b.UserTasks)
        .AsNoTracking()
        .FirstOrDefaultAsync(entity => entity.Id == id, cancellationToken);
    }
}

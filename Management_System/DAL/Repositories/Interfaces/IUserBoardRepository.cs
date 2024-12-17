using DAL.Entities;

namespace DAL.Repositories.Interfaces;

public interface IUserBoardRepository : IRepository<UserBoardEntity>
{
    Task<UserBoardEntity?> GetByUserIdAndBoardIdAsync(Guid userId, Guid boardId, CancellationToken cancellationToken);
    Task<IEnumerable<UserBoardEntity>> GetBoardsByUserIdAsync(Guid userId, CancellationToken cancellationToken);
    Task<IEnumerable<UserBoardEntity>> GetUsersByBoardIdAsync(Guid boardId, CancellationToken cancellationToken);
}
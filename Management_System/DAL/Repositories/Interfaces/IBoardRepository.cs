using DAL.Entities;

namespace DAL.Repositories.Interfaces;

public interface IBoardRepository : IRepository<BoardEntity>
{
    Task<BoardEntity> GetById(Guid id, CancellationToken cancellationToken);
}

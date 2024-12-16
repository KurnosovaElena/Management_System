using DAL.Entities;

namespace DAL.Repositories.Interfaces;

public interface ISubtaskRepository : IRepository<SubtaskEntity>
{
    Task<SubtaskEntity?> GetById(Guid id, CancellationToken cancellationToken);
}

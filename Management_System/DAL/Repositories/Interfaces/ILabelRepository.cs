using DAL.Entities;

namespace DAL.Repositories.Interfaces;

public interface ILabelRepository : IRepository<LabelEntity>
{
    Task<LabelEntity?> GetById(Guid id, CancellationToken cancellationToken);
}
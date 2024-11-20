using DAL.Entities;

namespace DAL.Repositories.Interfaces;

public interface ILabelRepository : IRepository<LabelEntity>
{
    Task<LabelEntity> GetLabel(Guid id, CancellationToken cancellationToken);
}
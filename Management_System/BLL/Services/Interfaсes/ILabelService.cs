using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaсes
{
    public interface ILabelService
    {
        Task<LabelEntity> GetById(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<LabelEntity>> GetAll(CancellationToken cancellationToken);
        Task<LabelEntity> Add(LabelEntity entity, CancellationToken cancellationToken);
        Task<LabelEntity> Update(Guid id, LabelEntity entity, CancellationToken cancellationToken);
        Task Delete(Guid id, CancellationToken cancellationToken);
    }
}
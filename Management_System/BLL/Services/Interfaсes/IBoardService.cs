using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaсes;
public interface IBoardService
{
    Task<BoardEntity> GetById(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<BoardEntity>> GetAll(CancellationToken cancellationToken);
    Task<BoardEntity> Add(BoardEntity entity, CancellationToken cancellationToken);
    Task<BoardEntity> Update(Guid id, BoardEntity entity, CancellationToken cancellationToken);
    Task<BoardEntity> Delete(Guid id, CancellationToken cancellationToken);
}

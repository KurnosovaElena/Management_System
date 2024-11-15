using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces;
public interface IBoardRepository : IRepository<BoardEntity>
{
    Task<IEnumerable<BoardEntity>> GetBoards(CancellationToken cancellationToken);
    Task<BoardEntity> GetBoard(Guid id, CancellationToken cancellationToken);
}

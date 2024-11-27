using BLL.DTO;
using DAL.Entities;

namespace BLL.Services.Interfaсes;

public interface IBoardService
{
    Task<BoardDTO> GetById(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<BoardDTO>> GetAll(CancellationToken cancellationToken);
    Task<BoardDTO> Add(BoardEntity entity, CancellationToken cancellationToken);
    Task<BoardDTO> Update(Guid id, BoardEntity entity, CancellationToken cancellationToken);
    Task Delete(Guid id, CancellationToken cancellationToken);
}
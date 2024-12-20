using BLL.DTO;
using BLL.DTO.CreateDTO;

namespace BLL.Services.Interfaces;

public interface IBoardService
{
    Task<BoardDTO> GetById(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<BoardDTO>> GetAll(CancellationToken cancellationToken);
    Task<BoardDTO> Add(CreateBoardDTO entity, CancellationToken cancellationToken);
    Task<BoardDTO> Update(Guid id, CreateBoardDTO entity, CancellationToken cancellationToken);
    Task Delete(Guid id, CancellationToken cancellationToken);
}
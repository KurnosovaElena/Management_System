using BLL.DTO;
using BLL.DTO.CreateDTO;

namespace BLL.Services.Interfaces;

public interface IBoardService
{
    Task<BoardDto> GetById(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<BoardDto>> GetAll(CancellationToken cancellationToken);
    Task<BoardDto> Add(CreateBoardDto entity, CancellationToken cancellationToken);
    Task<BoardDto> Update(Guid id, CreateBoardDto entity, CancellationToken cancellationToken);
    Task Delete(Guid id, CancellationToken cancellationToken);
}
using BLL.DTO;
using BLL.DTO.CreateDTO;

namespace BLL.Services.Interfaсes;

public interface IUserBoardService
{
    Task<UserBoardDto> GetByUserIdAndBoardIdAsync(Guid userId, Guid boardId, CancellationToken cancellationToken);
    Task<IEnumerable<UserBoardDto>> GetBoardsByUserIdAsync(Guid userId, CancellationToken cancellationToken);
    Task<IEnumerable<UserBoardDto>> GetUsersByBoardIdAsync(Guid boardId, CancellationToken cancellationToken);
    Task<IEnumerable<UserBoardDto>> GetAll(CancellationToken cancellationToken);
    Task<UserBoardDto> Add(CreateUserBoardDto entity, Guid userId, Guid boardId, CancellationToken cancellationToken);
    Task<UserBoardDto> Update(Guid userId, Guid boardId, CreateUserBoardDto entity, CancellationToken cancellationToken);
    Task Delete(Guid userId, Guid boardId, CancellationToken cancellationToken);
}

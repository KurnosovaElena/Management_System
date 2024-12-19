using BLL.DTO.CreateDTO;
using BLL.DTO;

namespace BLL.Services.Interfaсes;

public interface IUserBoardService
{
    Task<UserBoardDTO> GetByUserIdAndBoardIdAsync(Guid userId, Guid boardId, CancellationToken cancellationToken);
    Task<IEnumerable<UserBoardDTO>> GetBoardsByUserIdAsync(Guid userId, CancellationToken cancellationToken);
    Task<IEnumerable<UserBoardDTO>> GetUsersByBoardIdAsync(Guid boardId, CancellationToken cancellationToken);
    Task<IEnumerable<UserBoardDTO>> GetAll(CancellationToken cancellationToken);
    Task<UserBoardDTO> Add(CreateUserBoardDTO entity, Guid userId, Guid boardId, CancellationToken cancellationToken);
    Task<UserBoardDTO> Update(Guid userId, Guid boardId, CreateUserBoardDTO entity, CancellationToken cancellationToken);
    Task Delete(Guid userId, Guid boardId, CancellationToken cancellationToken);
}

using BLL.DTO;
using BLL.DTO.CreateDTO;

namespace BLL.Services.Interfaсes;

public interface IUserService
{
    Task<UserDTO> GetById(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<UserDTO>> GetAll(CancellationToken cancellationToken);
    Task<UserDTO> Add(CreateUserDTO entity, CancellationToken cancellationToken);
    Task<UserDTO> Update(Guid id, CreateUserDTO entity, CancellationToken cancellationToken);
    Task Delete(Guid id, CancellationToken cancellationToken);
}
using BLL.DTO;
using BLL.DTO.CreateDTO;

namespace BLL.Services.Interfaсes;

public interface IUserService
{
    Task<UserDto> GetById(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<UserDto>> GetAll(CancellationToken cancellationToken);
    Task<UserDto> Add(CreateUserDto entity, CancellationToken cancellationToken);
    Task<UserDto> Update(Guid id, CreateUserDto entity, CancellationToken cancellationToken);
    Task Delete(Guid id, CancellationToken cancellationToken);
}
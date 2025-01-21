using UserMicroserviceBLL.DTO;
using UserMicroserviceBLL.DTO.CreateDTO;

namespace UserMicroserviceBLL.Services.Interfaces;

public interface IUserService
{
    Task<UserDto> GetById(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<UserDto>> GetAll(CancellationToken cancellationToken);
    Task<UserDto> Add(CreateUserDto entity, CancellationToken cancellationToken);
    Task<UserDto> Update(Guid id, CreateUserDto entity, CancellationToken cancellationToken);
    Task Delete(Guid id, CancellationToken cancellationToken);
}

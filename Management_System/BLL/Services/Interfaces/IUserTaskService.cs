using BLL.DTO;
using BLL.DTO.CreateDTO;

namespace BLL.Services.Interfaсes;

public interface IUserTaskService
{
    Task<UserTaskDto> GetByUserIdAndTaskIdAsync(Guid userId, Guid taskId, CancellationToken cancellationToken);
    Task<IEnumerable<UserTaskDto>> GetTasksByUserIdAsync(Guid userId, CancellationToken cancellationToken);
    Task<IEnumerable<UserTaskDto>> GetUsersByTaskIdAsync(Guid taskId, CancellationToken cancellationToken);
    Task<IEnumerable<UserTaskDto>> GetAll(CancellationToken cancellationToken);
    Task<UserTaskDto> Add(CreateUserTaskDto entity, Guid userId, Guid taskId, CancellationToken cancellationToken);
    Task<UserTaskDto> Update(Guid userId, Guid taskId, CreateUserTaskDto entity, CancellationToken cancellationToken);
    Task Delete(Guid userId, Guid taskId, CancellationToken cancellationToken);
}

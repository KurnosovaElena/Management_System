using BLL.DTO;
using BLL.DTO.CreateDTO;

namespace BLL.Services.Interfaсes;

public interface IUserTaskService
{
    Task<UserTaskDTO> GetByUserIdAndTaskIdAsync(Guid userId, Guid taskId, CancellationToken cancellationToken);
    Task<IEnumerable<UserTaskDTO>> GetTasksByUserIdAsync(Guid userId, CancellationToken cancellationToken);
    Task<IEnumerable<UserTaskDTO>> GetUsersByTaskIdAsync(Guid taskId, CancellationToken cancellationToken);
    Task<IEnumerable<UserTaskDTO>> GetAll(CancellationToken cancellationToken);
    Task<UserTaskDTO> Add(CreateUserTaskDTO entity, Guid userId, Guid taskId, CancellationToken cancellationToken);
    Task<UserTaskDTO> Update(Guid userId, Guid taskId, CreateUserTaskDTO entity, CancellationToken cancellationToken);
    Task Delete(Guid userId, Guid taskId, CancellationToken cancellationToken);
}

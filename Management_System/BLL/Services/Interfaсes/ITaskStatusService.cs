using BLL.DTO;
using BLL.DTO.CreateDTO;

namespace BLL.Services.Interfaсes;

public interface ITaskStatusService
{
    Task<TaskStatusDto> GetById(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<TaskStatusDto>> GetAll(CancellationToken cancellationToken);
    Task<TaskStatusDto> Add(CreateTaskStatusDto entity, CancellationToken cancellationToken);
    Task<TaskStatusDto> Update(Guid id, CreateTaskStatusDto entity, CancellationToken cancellationToken);
    Task Delete(Guid id, CancellationToken cancellationToken);
}
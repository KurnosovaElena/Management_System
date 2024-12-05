using BLL.DTO;
using BLL.DTO.CreateDTO;

namespace BLL.Services.Interfaсes;

public interface ITaskStatusService
{
    Task<TaskStatusDTO> GetById(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<TaskStatusDTO>> GetAll(CancellationToken cancellationToken);
    Task<TaskStatusDTO> Add(CreateTaskStatusDTO entity, CancellationToken cancellationToken);
    Task<TaskStatusDTO> Update(Guid id, CreateTaskStatusDTO entity, CancellationToken cancellationToken);
    Task Delete(Guid id, CancellationToken cancellationToken);
}
using BLL.DTO;
using BLL.DTO.CreateDTO;

namespace BLL.Services.Interfaсes;

public interface ITasksService
{
    Task<TasksDTO> GetById(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<TasksDTO>> GetAll(CancellationToken cancellationToken);
    Task<TasksDTO> Add(CreateTasksDTO entity, CancellationToken cancellationToken);
    Task<TasksDTO> Update(Guid id, CreateTasksDTO entity, CancellationToken cancellationToken);
    Task Delete(Guid id, CancellationToken cancellationToken);
}
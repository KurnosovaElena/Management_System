using BLL.DTO;
using BLL.DTO.CreateDTO;

namespace BLL.Services.Interfaсes;

public interface ITasksService
{
    Task<TasksDto> GetById(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<TasksDto>> GetAll(CancellationToken cancellationToken);
    Task<TasksDto> Add(CreateTasksDto entity, CancellationToken cancellationToken);
    Task<TasksDto> Update(Guid id, CreateTasksDto entity, CancellationToken cancellationToken);
    Task Delete(Guid id, CancellationToken cancellationToken);
}
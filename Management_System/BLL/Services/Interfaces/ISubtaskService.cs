using BLL.DTO;
using BLL.DTO.CreateDTO;

namespace BLL.Services.Interfaсes;

public interface ISubtaskService
{
    Task<SubtaskDto> GetById(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<SubtaskDto>> GetAll(CancellationToken cancellationToken);
    Task<SubtaskDto> Add(CreateSubtaskDto entity, CancellationToken cancellationToken);
    Task<SubtaskDto> Update(Guid id, CreateSubtaskDto entity, CancellationToken cancellationToken);
    Task Delete(Guid id, CancellationToken cancellationToken);
}
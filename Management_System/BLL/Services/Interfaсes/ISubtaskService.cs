using BLL.DTO;
using BLL.DTO.CreateDTO;

namespace BLL.Services.Interfaсes;

public interface ISubtaskService
{
    Task<SubtaskDTO> GetById(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<SubtaskDTO>> GetAll(CancellationToken cancellationToken);
    Task<SubtaskDTO> Add(CreateSubtaskDTO entity, CancellationToken cancellationToken);
    Task<SubtaskDTO> Update(Guid id, CreateSubtaskDTO entity, CancellationToken cancellationToken);
    Task Delete(Guid id, CancellationToken cancellationToken);
}
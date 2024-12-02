using BLL.DTO;
using BLL.DTO.CreateDTO;

namespace BLL.Services.Interfaсes;

public interface ILabelService
{
    Task<LabelDTO> GetById(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<LabelDTO>> GetAll(CancellationToken cancellationToken);
    Task<LabelDTO> Add(CreateLabelDTO entity, CancellationToken cancellationToken);
    Task<LabelDTO> Update(Guid id, CreateLabelDTO entity, CancellationToken cancellationToken);
    Task Delete(Guid id, CancellationToken cancellationToken);
}
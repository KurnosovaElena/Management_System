using BLL.DTO;
using BLL.DTO.CreateDTO;

namespace BLL.Services.Interfaсes;

public interface ILabelService
{
    Task<LabelDto> GetById(Guid id, CancellationToken cancellationToken);
    Task<IEnumerable<LabelDto>> GetAll(CancellationToken cancellationToken);
    Task<LabelDto> Add(CreateLabelDto entity, CancellationToken cancellationToken);
    Task<LabelDto> Update(Guid id, CreateLabelDto entity, CancellationToken cancellationToken);
    Task Delete(Guid id, CancellationToken cancellationToken);
}
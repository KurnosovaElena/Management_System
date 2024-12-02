using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementaiton;
public class LabelService(ILabelRepository repository, IMapper mapper) : ILabelService
{
    public async Task<LabelDTO> Add(CreateLabelDTO entity, CancellationToken cancellationToken)
    {
        var label = mapper.Map<LabelEntity>(entity);

        await repository.Add(label, cancellationToken);

        var labelDTO = mapper.Map<LabelDTO>(label);

        return labelDTO;
    }

    public async Task<LabelDTO> GetById(Guid id, CancellationToken cancellationToken)
    {
        var label = await repository.GetById(id, cancellationToken);

        var labelDTO = mapper.Map<LabelDTO>(label);

        return labelDTO;
    }

    public async Task<IEnumerable<LabelDTO>> GetAll(CancellationToken cancellationToken)
    {
        var labels = await repository.GetAll(cancellationToken);

        var labelsDTO = mapper.Map<IEnumerable<LabelDTO>>(labels);

        return labelsDTO;
    }

    public async Task<LabelDTO> Update(Guid id, CreateLabelDTO entity, CancellationToken cancellationToken)
    {
        var label = await repository.GetById(id, cancellationToken);

        mapper.Map(label, entity);

        await repository.Update(label, cancellationToken);

        var labelDTO = mapper.Map<LabelDTO>(label);

        return labelDTO;
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var label = await repository.GetById(id, cancellationToken);

        await repository.Delete(label, cancellationToken);
    }
}
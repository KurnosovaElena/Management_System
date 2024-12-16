using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Exceptions;
using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementation;

public class LabelService(ILabelRepository repository, IMapper mapper) : ILabelService
{
    public async Task<LabelDTO> Add(CreateLabelDTO entity, CancellationToken cancellationToken)
    {
        try
        {
            var label = mapper.Map<LabelEntity>(entity);
            await repository.Add(label, cancellationToken);
            var labelDTO = mapper.Map<LabelDTO>(label);
            return labelDTO;
        }
        catch (Exception ex)
        {
            throw new ApplicationException("An error occurred while adding the label.", ex);
        }
    }

    public async Task<LabelDTO> GetById(Guid id, CancellationToken cancellationToken)
    {
        var label = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No label found");

        var labelDTO = mapper.Map<LabelDTO>(label);

        return labelDTO;
    }

    public async Task<IEnumerable<LabelDTO>> GetAll(CancellationToken cancellationToken)
    {
        var labels = await repository.GetAll(cancellationToken)
            ?? throw new NotFoundException("No labels found");

        var labelsDTO = mapper.Map<IEnumerable<LabelDTO>>(labels);

        return labelsDTO;
    }

    public async Task<LabelDTO> Update(Guid id, CreateLabelDTO entity, CancellationToken cancellationToken)
    {
        var label = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No label found");

        if (entity == null)
        {
            throw new BadRequestException("Invalid label data provided.");
        }

        mapper.Map(entity, label);

        await repository.Update(label, cancellationToken);

        var labelDTO = mapper.Map<LabelDTO>(label);

        return labelDTO;
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var label = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No label found");

        await repository.Delete(label, cancellationToken);
    }
}
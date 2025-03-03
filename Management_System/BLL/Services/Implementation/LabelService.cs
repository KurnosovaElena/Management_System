﻿using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Exceptions;
using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementation;

public class LabelService(ILabelRepository repository, IMapper mapper) : ILabelService
{
    public async Task<LabelDto> Add(CreateLabelDto entity, CancellationToken cancellationToken)
    {
        var label = mapper.Map<LabelEntity>(entity);
        await repository.Add(label, cancellationToken);
        var labelDTO = mapper.Map<LabelDto>(label);
        return labelDTO;
    }

    public async Task<LabelDto> GetById(Guid id, CancellationToken cancellationToken)
    {
        var label = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No label found");

        var labelDTO = mapper.Map<LabelDto>(label);

        return labelDTO;
    }

    public async Task<IEnumerable<LabelDto>> GetAll(CancellationToken cancellationToken)
    {
        var labels = await repository.GetAll(cancellationToken);

        var labelsDTO = mapper.Map<IEnumerable<LabelDto>>(labels);

        return labelsDTO;
    }

    public async Task<LabelDto> Update(Guid id, CreateLabelDto entity, CancellationToken cancellationToken)
    {
        if (entity is null)
        {
            throw new BadRequestException("Invalid label data provided.");
        }

        var label = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No label found");

        mapper.Map(entity, label);

        await repository.Update(label, cancellationToken);

        var labelDTO = mapper.Map<LabelDto>(label);

        return labelDTO;
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var label = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No label found");

        await repository.Delete(label, cancellationToken);
    }
}
using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Exceptions;
using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementation;

public class SubtaskService(ISubtaskRepository repository, IMapper mapper) : ISubtaskService
{
    public async Task<SubtaskDto> Add(CreateSubtaskDto entity, CancellationToken cancellationToken)
    {
        var subtask = mapper.Map<SubtaskEntity>(entity);
        await repository.Add(subtask, cancellationToken);
        var subtaskDTO = mapper.Map<SubtaskDto>(subtask);
        return subtaskDTO;
    }

    public async Task<SubtaskDto> GetById(Guid id, CancellationToken cancellationToken)
    {
        var subtask = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No subtask found");

        var subtaskDTO = mapper.Map<SubtaskDto>(subtask);

        return subtaskDTO;
    }

    public async Task<IEnumerable<SubtaskDto>> GetAll(CancellationToken cancellationToken)
    {
        var subtasks = await repository.GetAll(cancellationToken);

        var subtasksDTO = mapper.Map<IEnumerable<SubtaskDto>>(subtasks);

        return subtasksDTO;
    }

    public async Task<SubtaskDto> Update(Guid id, CreateSubtaskDto entity, CancellationToken cancellationToken)
    {
        if (entity is null)
        {
            throw new BadRequestException("Invalid subtask data provided.");
        }

        var subtask = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No subtask found");

        mapper.Map(entity, subtask);

        await repository.Update(subtask, cancellationToken);

        var subtaskDTO = mapper.Map<SubtaskDto>(subtask);

        return subtaskDTO;
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var subtask = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No subtask found");

        await repository.Delete(subtask, cancellationToken);
    }
}
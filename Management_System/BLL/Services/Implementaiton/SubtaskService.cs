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
    public async Task<SubtaskDTO> Add(CreateSubtaskDTO entity, CancellationToken cancellationToken)
    {
        var subtask = mapper.Map<SubtaskEntity>(entity);
        await repository.Add(subtask, cancellationToken);
        var subtaskDTO = mapper.Map<SubtaskDTO>(subtask);
        return subtaskDTO;
    }

    public async Task<SubtaskDTO> GetById(Guid id, CancellationToken cancellationToken)
    {
        var subtask = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No subtask found");

        var subtaskDTO = mapper.Map<SubtaskDTO>(subtask);

        return subtaskDTO;
    }

    public async Task<IEnumerable<SubtaskDTO>> GetAll(CancellationToken cancellationToken)
    {
        var subtasks = await repository.GetAll(cancellationToken)
            ?? throw new NotFoundException("No subtasks found");

        var subtasksDTO = mapper.Map<IEnumerable<SubtaskDTO>>(subtasks);

        return subtasksDTO;
    }

    public async Task<SubtaskDTO> Update(Guid id, CreateSubtaskDTO entity, CancellationToken cancellationToken)
    {
        if (entity is null)
        {
            throw new BadRequestException("Invalid subtask data provided.");
        }

        var subtask = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No subtask found");

        mapper.Map(entity, subtask);

        await repository.Update(subtask, cancellationToken);

        var subtaskDTO = mapper.Map<SubtaskDTO>(subtask);

        return subtaskDTO;
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var subtask = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No subtask found");

        await repository.Delete(subtask, cancellationToken);
    }
}
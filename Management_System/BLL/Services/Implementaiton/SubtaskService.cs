using AutoMapper;
using BLL.DTO.CreateDTO;
using BLL.DTO;
using BLL.Services.Interfaces;
using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementaiton;

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
        var subtask = await repository.GetById(id, cancellationToken);

        var subtaskDTO = mapper.Map<SubtaskDTO>(subtask);

        return subtaskDTO;
    }

    public async Task<IEnumerable<SubtaskDTO>> GetAll(CancellationToken cancellationToken)
    {
        var subtasks = await repository.GetAll(cancellationToken);

        var subtasksDTO = mapper.Map<IEnumerable<SubtaskDTO>>(subtasks);

        return subtasksDTO;
    }

    public async Task<SubtaskDTO> Update(Guid id, CreateSubtaskDTO entity, CancellationToken cancellationToken)
    {
        var subtask = await repository.GetById(id, cancellationToken);

        mapper.Map(entity, subtask);

        await repository.Update(subtask, cancellationToken);

        var subtaskDTO = mapper.Map<SubtaskDTO>(subtask);

        return subtaskDTO;
    }


    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var board = await repository.GetById(id, cancellationToken);
        await repository.Delete(board, cancellationToken);
    }
}

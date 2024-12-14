using BLL.DTO.CreateDTO;
using BLL.DTO;
using BLL.Services.Interfaсes;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/subtasks")]
public class SubtaskController(ISubtaskService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<SubtaskDTO>> GetAll(CancellationToken cancellationToken)
    {
        var subtasks = await service.GetAll(cancellationToken);
        return subtasks;
    }

    [HttpGet("{id}")]
    public async Task<SubtaskDTO> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var subtask = await service.GetById(id, cancellationToken);
        return subtask;
    }

    [HttpPost]
    public async Task<SubtaskDTO> Add([FromBody] CreateSubtaskDTO entity, CancellationToken cancellationToken)
    {
        var subtask = await service.Add(entity, cancellationToken);
        return subtask;
    }

    [HttpPut("{id}")]
    public async Task<SubtaskDTO> Update([FromRoute] Guid id, [FromBody] CreateSubtaskDTO entity, CancellationToken cancellationToken)
    {
        var subtask = await service.Update(id, entity, cancellationToken);
        return subtask;
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.Delete(id, cancellationToken);
    }
}
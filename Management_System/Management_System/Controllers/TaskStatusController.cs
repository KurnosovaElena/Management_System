using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Services.Interfaсes;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/task-statuses")]
public class TaskStatusesController(ITaskStatusService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<TaskStatusDto>> GetAll(CancellationToken cancellationToken)
    {
        var statuses = await service.GetAll(cancellationToken);
        return statuses;
    }

    [HttpGet("{id}")]
    public async Task<TaskStatusDto> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var status = await service.GetById(id, cancellationToken);
        return status;
    }

    [HttpPost]
    public async Task<TaskStatusDto> Add([FromBody] CreateTaskStatusDto entity, CancellationToken cancellationToken)
    {
        var status = await service.Add(entity, cancellationToken);
        return status;
    }

    [HttpPut("{id}")]
    public async Task<TaskStatusDto> Update([FromRoute] Guid id, [FromBody] CreateTaskStatusDto entity, CancellationToken cancellationToken)
    {
        var status = await service.Update(id, entity, cancellationToken);
        return status;
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.Delete(id, cancellationToken);
    }
}
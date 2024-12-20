using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Services.Interfaсes;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/tasks")]
public class TasksController(ITasksService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<TasksDto>> GetAll(CancellationToken cancellationToken)
    {
        var tasks = await service.GetAll(cancellationToken);
        return tasks;
    }

    [HttpGet("{id}")]
    public async Task<TasksDto> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var task = await service.GetById(id, cancellationToken);
        return task;
    }

    [HttpPost]
    public async Task<TasksDto> Add([FromBody] CreateTasksDto entity, CancellationToken cancellationToken)
    {
        var task = await service.Add(entity, cancellationToken);
        return task;
    }

    [HttpPut("{id}")]
    public async Task<TasksDto> Update([FromRoute] Guid id, [FromBody] CreateTasksDto entity, CancellationToken cancellationToken)
    {
        var task = await service.Update(id, entity, cancellationToken);
        return task;
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.Delete(id, cancellationToken);
    }
}
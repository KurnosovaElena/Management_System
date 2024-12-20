using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Services.Interfaсes;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/user-tasks")]
public class UserTaskController(IUserTaskService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<UserTaskDTO>> GetAll(CancellationToken cancellationToken)
    {
        var userTasks = await service.GetAll(cancellationToken);
        return userTasks;
    }

    [HttpGet("{userId}/{taskId}")]
    public async Task<UserTaskDTO> GetByUserIdAndBoardIdAsync([FromRoute] Guid userId, [FromRoute] Guid taskId, CancellationToken cancellationToken)
    {
        return await service.GetByUserIdAndTaskIdAsync(userId, taskId, cancellationToken);
    }

    [HttpGet("user/{userId}")]
    public async Task<IEnumerable<UserTaskDTO>> GetBoardsByUserIdAsync([FromRoute] Guid userId, CancellationToken cancellationToken)
    {
        return await service.GetTasksByUserIdAsync(userId, cancellationToken);
    }

    [HttpGet("board/{taskId}")]
    public async Task<IEnumerable<UserTaskDTO>> GetUsersByBoardIdAsync([FromRoute] Guid taskId, CancellationToken cancellationToken)
    {
        return await service.GetUsersByTaskIdAsync(taskId, cancellationToken);
    }

    [HttpPost("{userId}/{taskId}")]
    public async Task<UserTaskDTO> Add([FromBody] CreateUserTaskDTO entity, [FromRoute] Guid userId, [FromRoute] Guid taskId, CancellationToken cancellationToken)
    {
        var userTask = await service.Add(entity, userId, taskId, cancellationToken);
        return userTask;
    }

    [HttpPut("{userId}/{taskId}")]
    public async Task<UserTaskDTO> Update([FromRoute] Guid userId, [FromRoute] Guid taskId, [FromBody] CreateUserTaskDTO entity, CancellationToken cancellationToken)
    {
        var userTask = await service.Update(userId, taskId, entity, cancellationToken);
        return userTask;
    }

    [HttpDelete("{userId}/{taskId}")]
    public async Task Delete(Guid userId, Guid taskId, CancellationToken cancellationToken)
    {
        await service.Delete(userId, taskId, cancellationToken);
    }
}

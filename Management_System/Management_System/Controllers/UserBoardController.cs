using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Services.Interfaсes;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/user-boards")]
public class UserBoardController(IUserBoardService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<UserBoardDto>> GetAll(CancellationToken cancellationToken)
    {
        var userBoards = await service.GetAll(cancellationToken);
        return userBoards;
    }

    [HttpGet("{userId}/{boardId}")]
    public async Task<UserBoardDto> GetByUserIdAndBoardIdAsync([FromRoute] Guid userId, [FromRoute] Guid boardId, CancellationToken cancellationToken)
    {
        return await service.GetByUserIdAndBoardIdAsync(userId, boardId, cancellationToken);
    }

    [HttpGet("user/{userId}")]
    public async Task<IEnumerable<UserBoardDto>> GetBoardsByUserIdAsync([FromRoute] Guid userId, CancellationToken cancellationToken)
    {
        return await service.GetBoardsByUserIdAsync(userId, cancellationToken);
    }

    [HttpGet("board/{boardId}")]
    public async Task<IEnumerable<UserBoardDto>> GetUsersByBoardIdAsync([FromRoute] Guid boardId, CancellationToken cancellationToken)
    {
        return await service.GetUsersByBoardIdAsync(boardId, cancellationToken);
    }

    [HttpPost("{userId}/{boardId}")]
    public async Task<UserBoardDto> Add([FromBody] CreateUserBoardDto entity, [FromRoute] Guid userId, [FromRoute] Guid boardId, CancellationToken cancellationToken)
    {
        var userBoard = await service.Add(entity, userId, boardId, cancellationToken);
        return userBoard;
    }

    [HttpPut("{userId}/{boardId}")]
    public async Task<UserBoardDto> Update([FromRoute] Guid userId, [FromRoute] Guid boardId, [FromBody] CreateUserBoardDto entity, CancellationToken cancellationToken)
    {
        var userBoard = await service.Update(userId, boardId, entity, cancellationToken);
        return userBoard;
    }

    [HttpDelete("{userId}/{boardId}")]
    public async Task Delete(Guid userId, Guid boardId, CancellationToken cancellationToken)
    {
        await service.Delete(userId, boardId, cancellationToken);
    }
}

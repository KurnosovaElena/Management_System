using BLL.Services.Interfaсes;
using DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers;

[ApiController]
[Route("[controller]")]
public class BoardController(IBoardService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<BoardEntity>> GetAll(CancellationToken cancellationToken)
    {
        var boards = await service.GetAll(cancellationToken);
        return boards;
    }

    [HttpGet("{id}")]
    public async Task<BoardEntity> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var board = await service.GetById(id, cancellationToken);
        return board;
    }

    [HttpPost]
    public async Task<BoardEntity> Add(BoardEntity entity, CancellationToken cancellationToken)
    {
        var board = await service.Add(entity, cancellationToken);

        return board;
    }

    [HttpPut("{id}")]
    public async Task<BoardEntity> Update(Guid id, BoardEntity entity, CancellationToken cancellationToken)
    {
        var board = await service.Update(id, entity, cancellationToken);
        return board;
    }

    [HttpDelete("{id}")]
    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        await service.Delete(id, cancellationToken);
    }
}
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/boards")]
public class BoardsController(IBoardService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<BoardDto>> GetAll(CancellationToken cancellationToken)
    {
        var boards = await service.GetAll(cancellationToken);
        return boards;
    }

    [HttpGet("{id}")]
    public async Task<BoardDto> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var board = await service.GetById(id, cancellationToken);
        return board;
    }

    [HttpPost]
    public async Task<BoardDto> Add([FromBody] CreateBoardDto entity, CancellationToken cancellationToken)
    {
        var board = await service.Add(entity, cancellationToken);
        return board;
    }

    [HttpPut("{id}")]
    public async Task<BoardDto> Update([FromRoute] Guid id, [FromBody] CreateBoardDto entity, CancellationToken cancellationToken)
    {
        var board = await service.Update(id, entity, cancellationToken);
        return board;
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.Delete(id, cancellationToken);
    }
}
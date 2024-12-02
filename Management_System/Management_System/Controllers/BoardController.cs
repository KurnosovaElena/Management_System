using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Services.Interfaсes;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/boards")]
public class BoardsController(IBoardService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<BoardDTO>> GetAll(CancellationToken cancellationToken)
    {
        var boards = await service.GetAll(cancellationToken);
        return boards;
    }

    [HttpGet("{id}")]
    public async Task<BoardDTO> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var board = await service.GetById(id, cancellationToken);
        return board;
    }

    [HttpPost]
    public async Task<BoardDTO> Add([FromBody] CreateBoardDTO entity, CancellationToken cancellationToken)
    {
        var board = await service.Add(entity, cancellationToken);
        return board;
    }

    [HttpPut("{id}")]
    public async Task<BoardDTO> Update([FromRoute] Guid id, [FromBody] CreateBoardDTO entity, CancellationToken cancellationToken)
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
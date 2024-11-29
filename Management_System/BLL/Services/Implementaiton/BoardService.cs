using BLL.DTO;
using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementaiton;

public class BoardService(IBoardRepository repository) : IBoardService
{
    public async Task<BoardDTO> Add(BoardEntity entity, CancellationToken cancellationToken)
    {
        await repository.Add(entity, cancellationToken);

        var boardDTO = new BoardDTO
        {
            Id = entity.Id,
            Name = entity.Name,
            Description = entity.Description,
            TaskStatus = entity.TaskStatus,
            UserBoards = entity.UserBoards,
        };

        return boardDTO;
    }

    public async Task<BoardDTO> GetById(Guid id, CancellationToken cancellationToken)
    {
        var board = await repository.GetById(id, cancellationToken);

        var boardDTO = new BoardDTO
        {
            Id = board.Id,
            Name = board.Name,
            Description = board.Description,
            TaskStatus = board.TaskStatus,
            UserBoards = board.UserBoards,
        };

        return boardDTO;
    }

    public async Task<IEnumerable<BoardDTO>> GetAll(CancellationToken cancellationToken)
    {
        var boards = await repository.GetAll(cancellationToken);
        var boardsDTO = boards.Select(boards => new BoardDTO
        {
            Id = boards.Id,
            Name = boards.Name,
            Description = boards.Description,
            TaskStatus = boards.TaskStatus,
            UserBoards = boards.UserBoards,
        });

        return boardsDTO;
    }

    public async Task<BoardDTO> Update(Guid id, BoardEntity entity, CancellationToken cancellationToken)
    {
        var board = await repository.GetById(id, cancellationToken);

        await repository.Update(board, cancellationToken);

        var boardDTO = new BoardDTO
        {
            Id = board.Id,
            Name = board.Name,
            Description = board.Description,
            TaskStatus = board.TaskStatus,
            UserBoards = board.UserBoards,
        };

        return boardDTO;
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var board = await repository.GetById(id, cancellationToken);

        await repository.Delete(board, cancellationToken);
    }
}
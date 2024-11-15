using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementaiton;
public class BoardService(IBoardRepository repository) : IBoardService
{
    public async Task<BoardEntity> Add(BoardEntity entity, CancellationToken cancellationToken)
    {
        await repository.Add(entity, cancellationToken);

        return entity;
    }

    public async Task<BoardEntity> GetById(Guid id, CancellationToken cancellationToken)
    {
        var board = await repository.GetBoard(id, cancellationToken);

        return board;
    }

    public async Task<IEnumerable<BoardEntity>> GetAll(CancellationToken cancellationToken)
    {
        var boards = await repository.GetBoards(cancellationToken);
        return boards;
    }

    public async Task<BoardEntity> Update(Guid id, BoardEntity entity, CancellationToken cancellationToken)
    {
        var board = await repository.GetBoard(id, cancellationToken);

        await repository.Update(board, cancellationToken);

        return entity;
    }

    public async Task<BoardEntity> Delete(Guid id, CancellationToken cancellationToken)
    {
        var board = await repository.GetBoard(id, cancellationToken);

        await repository.Delete(board, cancellationToken);

        return board;
    }
}
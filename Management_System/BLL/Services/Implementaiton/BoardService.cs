using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementation;

public class BoardService : IBoardService
{
    private readonly IBoardRepository repository;
    private readonly IMapper mapper;

    public BoardService(IBoardRepository repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public async Task<BoardDTO> Add(CreateBoardDTO entity, CancellationToken cancellationToken)
    {
        var board = mapper.Map<BoardEntity>(entity);
        await repository.Add(board, cancellationToken);
        var boardDTO = mapper.Map<BoardDTO>(board);
        return boardDTO;
    }

    public async Task<BoardDTO> GetById(Guid id, CancellationToken cancellationToken)
    {
        var board = await repository.GetById(id, cancellationToken);
        var boardDTO = mapper.Map<BoardDTO>(board);
        return boardDTO;
    }

    public async Task<IEnumerable<BoardDTO>> GetAll(CancellationToken cancellationToken)
    {
        var boards = await repository.GetAll(cancellationToken);
        var boardsDTO = mapper.Map<IEnumerable<BoardDTO>>(boards);
        return boardsDTO;
    }

    public async Task<BoardDTO> Update(Guid id, CreateBoardDTO entity, CancellationToken cancellationToken)
    {
        var board = await repository.GetById(id, cancellationToken);
        mapper.Map(entity, board);
        await repository.Update(board, cancellationToken);
        var boardDTO = mapper.Map<BoardDTO>(board);
        return boardDTO;
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var board = await repository.GetById(id, cancellationToken);
        await repository.Delete(board, cancellationToken);
    }
}


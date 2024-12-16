using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Exceptions;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementation;

public class BoardService(IBoardRepository repository, IMapper mapper) : IBoardService
{
    public async Task<BoardDTO> Add(CreateBoardDTO entity, CancellationToken cancellationToken)
    {
        try
        {
            var board = mapper.Map<BoardEntity>(entity);
            await repository.Add(board, cancellationToken);
            var boardDTO = mapper.Map<BoardDTO>(board);
            return boardDTO;
        }
        catch (Exception ex)
        {
            throw new ApplicationException("An error occurred while adding the board.", ex);
        }
    }

    public async Task<BoardDTO> GetById(Guid id, CancellationToken cancellationToken)
    {
        var board = await repository.GetById(id, cancellationToken)
        ?? throw new NotFoundException("No board found");

        var boardDTO = mapper.Map<BoardDTO>(board);

        return boardDTO;
    }

    public async Task<IEnumerable<BoardDTO>> GetAll(CancellationToken cancellationToken)
    {
        var boards = await repository.GetAll(cancellationToken)
            ?? throw new NotFoundException("No boards found");

        var boardsDTO = mapper.Map<IEnumerable<BoardDTO>>(boards);

        return boardsDTO;
    }

    public async Task<BoardDTO> Update(Guid id, CreateBoardDTO entity, CancellationToken cancellationToken)
    {
        var board = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No board found");

        if (entity == null) 
        { 
            throw new BadRequestException("Invalid board data provided."); 
        }

        mapper.Map(entity, board);
        await repository.Update(board, cancellationToken);
        var boardDTO = mapper.Map<BoardDTO>(board);
        return boardDTO;
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var board = await repository.GetById(id, cancellationToken)
                ?? throw new NotFoundException("No board found");
        await repository.Delete(board, cancellationToken);
    }
}
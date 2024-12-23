using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Exceptions;
using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementation;

public class UserBoardService(IUserBoardRepository repository, IMapper mapper) : IUserBoardService
{
    public async Task<UserBoardDto> Add(CreateUserBoardDto entity, Guid userId, Guid boardId, CancellationToken cancellationToken)
    {
        var userBoard = mapper.Map<UserBoardEntity>(entity);
        userBoard.UserId = userId;
        userBoard.BoardId = boardId;

        await repository.Add(userBoard, cancellationToken);
        var userBoardDTO = mapper.Map<UserBoardDto>(userBoard);

        return userBoardDTO;
    }

    public async Task<UserBoardDto> GetByUserIdAndBoardIdAsync(Guid userId, Guid boardId, CancellationToken cancellationToken)
    {
        var userBoardEntity = await repository.GetByUserIdAndBoardIdAsync(userId, boardId, cancellationToken) 
            ?? throw new NotFoundException($"No user board found for userId: {userId}, boardId: {boardId}");

        return mapper.Map<UserBoardDto>(userBoardEntity);
    }

    public async Task<IEnumerable<UserBoardDto>> GetBoardsByUserIdAsync(Guid userId, CancellationToken cancellationToken)
    {
        var userBoardEntities = await repository.GetBoardsByUserIdAsync(userId, cancellationToken);
        return mapper.Map<IEnumerable<UserBoardDto>>(userBoardEntities);
    }

    public async Task<IEnumerable<UserBoardDto>> GetUsersByBoardIdAsync(Guid boardId, CancellationToken cancellationToken)
    {
        var userBoardEntities = await repository.GetUsersByBoardIdAsync(boardId, cancellationToken);
        return mapper.Map<IEnumerable<UserBoardDto>>(userBoardEntities);
    }

    public async Task<IEnumerable<UserBoardDto>> GetAll(CancellationToken cancellationToken)
    {
        var usersBoards = await repository.GetAll(cancellationToken);

        var usersBoardsDTO = mapper.Map<IEnumerable<UserBoardDto>>(usersBoards);

        return usersBoardsDTO;
    }

    public async Task<UserBoardDto> Update(Guid userId, Guid boardId, CreateUserBoardDto entity, CancellationToken cancellationToken)
    {
        var userBoard = await repository.GetByUserIdAndBoardIdAsync(userId, boardId, cancellationToken)
            ?? throw new NotFoundException($"No user board found for userId: {userId}, boardId: {boardId}");
        mapper.Map(entity, userBoard);
        await repository.Update(userBoard, cancellationToken);
        var userBoardDTO = mapper.Map<UserBoardDto>(userBoard);

        return userBoardDTO;
    }

    public async Task Delete(Guid userId, Guid boardId, CancellationToken cancellationToken)
    {
        var userBoard = await repository.GetByUserIdAndBoardIdAsync(userId, boardId, cancellationToken)
            ?? throw new NotFoundException($"No user board found for userId: {userId}, boardId: {boardId}");
        await repository.Delete(userBoard, cancellationToken);
    }
}

using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementaiton;

public class UserBoardService(IUserBoardRepository repository, IMapper mapper) : IUserBoardService
{
    public async Task<UserBoardDTO> Add(CreateUserBoardDTO entity, Guid userId, Guid boardId, CancellationToken cancellationToken)
    {
        var userBoard = mapper.Map<UserBoardEntity>(entity);
        userBoard.UserId = userId; 
        userBoard.BoardId = boardId; 

        await repository.Add(userBoard, cancellationToken);
        var userBoardDTO = mapper.Map<UserBoardDTO>(userBoard);

        return userBoardDTO;
    }

    public async Task<UserBoardDTO> GetByUserIdAndBoardIdAsync(Guid userId, Guid boardId, CancellationToken cancellationToken)
    {
        var userBoardEntity = await repository.GetByUserIdAndBoardIdAsync(userId, boardId, cancellationToken);
        return mapper.Map<UserBoardDTO>(userBoardEntity);
    }

    public async Task<IEnumerable<UserBoardDTO>> GetBoardsByUserIdAsync(Guid userId, CancellationToken cancellationToken)
    {
        var userBoardEntities = await repository.GetBoardsByUserIdAsync(userId, cancellationToken);
        return mapper.Map<IEnumerable<UserBoardDTO>>(userBoardEntities);
    }

    public async Task<IEnumerable<UserBoardDTO>> GetUsersByBoardIdAsync(Guid boardId, CancellationToken cancellationToken)
    {
        var userBoardEntities = await repository.GetUsersByBoardIdAsync(boardId, cancellationToken);
        return mapper.Map<IEnumerable<UserBoardDTO>>(userBoardEntities);
    }

    public async Task<IEnumerable<UserBoardDTO>> GetAll(CancellationToken cancellationToken)
    {
        var usersBoards = await repository.GetAll(cancellationToken);

        var usersBoardsDTO = mapper.Map<IEnumerable<UserBoardDTO>>(usersBoards);

        return usersBoardsDTO;
    }

    public async Task<UserBoardDTO> Update(Guid userId, Guid boardId, CreateUserBoardDTO entity, CancellationToken cancellationToken)
    {
        var userBoard = await repository.GetByUserIdAndBoardIdAsync(userId, boardId, cancellationToken) 
            ?? throw new Exception("UserBoard not found");
        mapper.Map(entity, userBoard);
        await repository.Update(userBoard, cancellationToken);
        var userBoardDTO = mapper.Map<UserBoardDTO>(userBoard);

        return userBoardDTO;
    }

    public async Task Delete(Guid userId, Guid boardId, CancellationToken cancellationToken)
    {
        var userBoard = await repository.GetByUserIdAndBoardIdAsync(userId, boardId, cancellationToken) 
            ?? throw new Exception("UserBoard not found");
        await repository.Delete(userBoard, cancellationToken);
    }
}

using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Exceptions;
using BLL.Services.Implementation;
using DAL.Entities;
using DAL.Enums;
using DAL.Repositories.Interfaces;
using Moq;

namespace ManagementSystemTest.ServicesTests;

public class UserBoardServiceTests
{
    private readonly Mock<IUserBoardRepository> _userBoardRepositoryMock;
    private readonly IMapper _mapper;
    private readonly UserBoardService _userBoardService;

    public UserBoardServiceTests()
    {
        _userBoardRepositoryMock = new Mock<IUserBoardRepository>();
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<CreateUserBoardDto, UserBoardEntity>();
            cfg.CreateMap<UserBoardEntity, UserBoardDto>();
        });
        _mapper = config.CreateMapper();
        _userBoardService = new UserBoardService(_userBoardRepositoryMock.Object, _mapper);
    }

    [Fact]
    public async Task Add_ValidUserBoard_AddsAndReturnsUserBoardDTO()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var boardId = Guid.NewGuid();
        var createUserBoardDto = new CreateUserBoardDto
        {
            Role = BoardRole.Admin
        };

        var userBoardEntity = new UserBoardEntity
        {
            UserId = userId,
            BoardId = boardId,
            Role = createUserBoardDto.Role
        };

        _userBoardRepositoryMock.Setup(repo => repo.Add(It.IsAny<UserBoardEntity>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(userBoardEntity);

        // Act
        var result = await _userBoardService.Add(createUserBoardDto, userId, boardId, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(userId, result.UserId);
        Assert.Equal(boardId, result.BoardId);
        Assert.Equal(createUserBoardDto.Role, result.Role);
    }

    [Fact]
    public async Task GetByUserIdAndBoardIdAsync_UserBoardExists_ReturnsUserBoardDTO()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var boardId = Guid.NewGuid();
        var userBoardEntity = new UserBoardEntity
        {
            UserId = userId,
            BoardId = boardId,
            Role = BoardRole.Admin // Example role
        };

        _userBoardRepositoryMock.Setup(repo => repo.GetByUserIdAndBoardIdAsync(userId, boardId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(userBoardEntity);

        // Act
        var result = await _userBoardService.GetByUserIdAndBoardIdAsync(userId, boardId, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(userBoardEntity.UserId, result.UserId);
        Assert.Equal(userBoardEntity.BoardId, result.BoardId);
        Assert.Equal(userBoardEntity.Role, result.Role);
    }

    [Fact]
    public async Task GetByUserIdAndBoardIdAsync_UserBoardDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var boardId = Guid.NewGuid();
        _userBoardRepositoryMock.Setup(repo => repo.GetByUserIdAndBoardIdAsync(userId, boardId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((UserBoardEntity?)null);

        // Act
        var act = async () => await _userBoardService.GetByUserIdAndBoardIdAsync(userId, boardId, CancellationToken.None);

        // Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(act);
        Assert.Equal($"No user board found for userId: {userId}, boardId: {boardId}", exception.Message);
    }

    [Fact]
    public async Task GetBoardsByUserIdAsync_ReturnsListOfUserBoards()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var userBoards = new List<UserBoardEntity>
        {
                new UserBoardEntity { UserId = userId, BoardId = Guid.NewGuid(), Role = BoardRole.Read },
                new UserBoardEntity { UserId = userId, BoardId = Guid.NewGuid(), Role = BoardRole.Admin }
        };

        _userBoardRepositoryMock.Setup(repo => repo.GetBoardsByUserIdAsync(userId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(userBoards);

        // Act
        var result = await _userBoardService.GetBoardsByUserIdAsync(userId, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Equal(userBoards[0].BoardId, result.First().BoardId);
        Assert.Equal(userBoards[1].BoardId, result.Last().BoardId);
    }

    [Fact]
    public async Task GetUsersByBoardIdAsync_ReturnsListOfUserBoards()
    {
        // Arrange
        var boardId = Guid.NewGuid();
        var userBoards = new List<UserBoardEntity>
        {
                new UserBoardEntity { UserId = Guid.NewGuid(), BoardId = boardId, Role = BoardRole.Write },
                new UserBoardEntity { UserId = Guid.NewGuid(), BoardId = boardId, Role = BoardRole.Admin }
        };

        _userBoardRepositoryMock.Setup(repo => repo.GetUsersByBoardIdAsync(boardId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(userBoards);

        // Act
        var result = await _userBoardService.GetUsersByBoardIdAsync(boardId, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Equal(userBoards[0].UserId, result.First().UserId);
        Assert.Equal(userBoards[1].UserId, result.Last().UserId);
    }

    [Fact]
    public async Task Update_UserBoardExists_UpdatesUserBoard()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var boardId = Guid.NewGuid();
        var existingUserBoard = new UserBoardEntity
        {
            UserId = userId,
            BoardId = boardId,
            Role = BoardRole.Read
        };
        var updateDto = new CreateUserBoardDto
        {
            Role = BoardRole.Admin
        };

        _userBoardRepositoryMock.Setup(repo => repo.GetByUserIdAndBoardIdAsync(userId, boardId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingUserBoard);

        // Act
        var result = await _userBoardService.Update(userId, boardId, updateDto, CancellationToken.None);

        // Assert
        _userBoardRepositoryMock.Verify(repo => repo.Update(existingUserBoard, It.IsAny<CancellationToken>()), Times.Once);
        Assert.Equal(BoardRole.Admin, existingUserBoard.Role);
    }

    [Fact]
    public async Task Update_UserBoardDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var boardId = Guid.NewGuid();
        var updateDto = new CreateUserBoardDto { Role = BoardRole.Admin };

        _userBoardRepositoryMock.Setup(repo => repo.GetByUserIdAndBoardIdAsync(userId, boardId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((UserBoardEntity?)null);

        // Act
        var act = async () => await _userBoardService.Update(userId, boardId, updateDto, CancellationToken.None);

        // Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(act);
        Assert.Equal($"No user board found for userId: {userId}, boardId: {boardId}", exception.Message);
    }

    [Fact]
    public async Task Delete_UserBoardExists_DeletesUserBoard()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var boardId = Guid.NewGuid();
        var existingUserBoard = new UserBoardEntity
        {
            UserId = userId,
            BoardId = boardId,
            Role = BoardRole.Admin
        };

        _userBoardRepositoryMock.Setup(repo => repo.GetByUserIdAndBoardIdAsync(userId, boardId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingUserBoard);

        // Act
        await _userBoardService.Delete(userId, boardId, CancellationToken.None);

        // Assert
        _userBoardRepositoryMock.Verify(repo => repo.Delete(existingUserBoard, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task Delete_UserBoardDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var boardId = Guid.NewGuid();
        _userBoardRepositoryMock.Setup(repo => repo.GetByUserIdAndBoardIdAsync(userId, boardId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((UserBoardEntity?)null);

        // Act
        var act = async () => await _userBoardService.Delete(userId, boardId, CancellationToken.None);

        // Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(act);
        Assert.Equal($"No user board found for userId: {userId}, boardId: {boardId}", exception.Message);
    }
}

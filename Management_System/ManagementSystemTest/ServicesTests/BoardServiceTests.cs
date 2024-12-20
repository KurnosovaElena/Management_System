using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Exceptions;
using BLL.Services.Implementation;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Moq;

namespace ManagementSystemTest.ServicesTests;

public class BoardServiceTests
{
    private readonly Mock<IBoardRepository> _boardRepositoryMock;
    private readonly IMapper _mapper;
    private readonly BoardService _boardService;

    public BoardServiceTests()
    {
        _boardRepositoryMock = new Mock<IBoardRepository>();
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<CreateBoardDTO, BoardEntity>();
            cfg.CreateMap<BoardEntity, BoardDTO>();
        });
        _mapper = config.CreateMapper();
        _boardService = new BoardService(_boardRepositoryMock.Object, _mapper);
    }

    [Fact]
    public async Task GetById_BoardExists_ReturnsBoardDTO()
    {
        // Arrange
        var boardId = Guid.NewGuid();
        var boardEntity = new BoardEntity
        {
            Id = boardId,
            Name = "Test Board",
            Description = "This is a test board.",
            TaskStatus = new List<TaskStatusEntity>(),
            UserBoards = new List<UserBoardEntity>()
        };

        _boardRepositoryMock.Setup(repo => repo.GetById(boardId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(boardEntity);

        // Act
        var result = await _boardService.GetById(boardId, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(boardId, result.Id);
        Assert.Equal("Test Board", result.Name);
        Assert.Equal("This is a test board.", result.Description);
    }

    [Fact]
    public async Task GetById_BoardDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var boardId = Guid.NewGuid();
        _boardRepositoryMock.Setup(repo => repo.GetById(boardId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((BoardEntity)null);

        // Act
        var act = async () => await _boardService.GetById(boardId, CancellationToken.None);

        // Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(act);
        Assert.Equal("No board found", exception.Message);
    }

    [Fact]
    public async Task GetAll_ReturnsListOfBoards()
    {
        // Arrange
        var boards = new List<BoardEntity>
            {
                new BoardEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Board One",
                    Description = "Description for Board One",
                    TaskStatus = new List<TaskStatusEntity>(),
                    UserBoards = new List<UserBoardEntity>()
                },
                new BoardEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Board Two",
                    Description = "Description for Board Two",
                    TaskStatus = new List<TaskStatusEntity>(),
                    UserBoards = new List<UserBoardEntity>()
                }
            };

        _boardRepositoryMock.Setup(repo => repo.GetAll(It.IsAny<CancellationToken>()))
            .ReturnsAsync(boards);

        // Act
        var result = await _boardService.GetAll(CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Equal("Board One", result.First().Name);
        Assert.Equal("Board Two", result.Last().Name);
    }

    [Fact]
    public async Task Update_BoardExists_UpdatesBoard()
    {
        // Arrange
        var boardId = Guid.NewGuid();
        var existingBoard = new BoardEntity
        {
            Id = boardId,
            Name = "Old Board Name",
            Description = "Old Description",
            TaskStatus = new List<TaskStatusEntity>(),
            UserBoards = new List<UserBoardEntity>()
        };
        var updateDto = new CreateBoardDTO
        {
            Name = "Updated Board Name",
            Description = "Updated Description"
        };

        _boardRepositoryMock.Setup(repo => repo.GetById(boardId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingBoard);

        // Act
        var result = await _boardService.Update(boardId, updateDto, CancellationToken.None);

        // Assert
        _boardRepositoryMock.Verify(repo => repo.Update(existingBoard, It.IsAny<CancellationToken>()), Times.Once);
        Assert.Equal("Updated Board Name", existingBoard.Name);
        Assert.Equal("Updated Description", existingBoard.Description);
    }

    [Fact]
    public async Task Update_BoardDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var boardId = Guid.NewGuid();
        var updateDto = new CreateBoardDTO { Name = "New Name", Description = "New Description" };

        _boardRepositoryMock.Setup(repo => repo.GetById(boardId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((BoardEntity)null);

        // Act
        var act = async () => await _boardService.Update(boardId, updateDto, CancellationToken.None);

        // Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(act);
        Assert.Equal("No board found", exception.Message);
    }

    [Fact]
    public async Task Delete_BoardExists_DeletesBoard()
    {
        // Arrange
        var boardId = Guid.NewGuid();
        var existingBoard = new BoardEntity
        {
            Id = boardId,
            Name = "Board to Delete",
            Description = "This board will be deleted."
        };

        _boardRepositoryMock.Setup(repo => repo.GetById(boardId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingBoard);

        // Act
        await _boardService.Delete(boardId, CancellationToken.None);

        // Assert
        _boardRepositoryMock.Verify(repo => repo.Delete(existingBoard, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task Delete_BoardDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var boardId = Guid.NewGuid();
        _boardRepositoryMock.Setup(repo => repo.GetById(boardId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((BoardEntity)null);

        // Act
        var act = async () => await _boardService.Delete(boardId, CancellationToken.None);

        // Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(act);
        Assert.Equal("No board found", exception.Message);
    }
}

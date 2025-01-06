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

public class UserTaskServiceTests
{
    private readonly Mock<IUserTaskRepository> _userTaskRepositoryMock;
    private readonly IMapper _mapper;
    private readonly Mock<IMapper> _mapperMock;
    private readonly UserTaskService _userTaskService;

    public UserTaskServiceTests()
    {
        _userTaskRepositoryMock = new Mock<IUserTaskRepository>();
        _mapperMock = new Mock<IMapper>();
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<CreateUserTaskDto, UserTaskEntity>();
            cfg.CreateMap<UserTaskEntity, UserTaskDto>();
        });
        _mapper = config.CreateMapper();
        _userTaskService = new UserTaskService(_userTaskRepositoryMock.Object, _mapper);
    }

    [Fact]
    public async Task Add_ValidUserTask_AddsAndReturnsUserTaskDTO()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var taskId = Guid.NewGuid();
        var createUserTaskDto = new CreateUserTaskDto
        {
            Role = TaskRole.Reviewer
        };

        var userTaskEntity = new UserTaskEntity
        {
            UserId = userId,
            TaskId = taskId,
            Role = createUserTaskDto.Role
        };

        _userTaskRepositoryMock.Setup(repo => repo.Add(It.IsAny<UserTaskEntity>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(userTaskEntity);

        // Act
        var result = await _userTaskService.Add(createUserTaskDto, userId, taskId, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(userId, result.UserId);
        Assert.Equal(taskId, result.TaskId);
        Assert.Equal(createUserTaskDto.Role, result.Role);
    }

    [Fact]
    public async Task GetByUserIdAndTaskIdAsync_UserTaskExists_ReturnsUserTaskDTO()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var taskId = Guid.NewGuid();
        var userTaskEntity = new UserTaskEntity
        {
            UserId = userId,
            TaskId = taskId,
            Role = TaskRole.Assignee
        };

        _userTaskRepositoryMock.Setup(repo => repo.GetByUserIdAndTaskIdAsync(userId, taskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(userTaskEntity);

        // Act
        var result = await _userTaskService.GetByUserIdAndTaskIdAsync(userId, taskId, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(userTaskEntity.UserId, result.UserId);
        Assert.Equal(userTaskEntity.TaskId, result.TaskId);
        Assert.Equal(userTaskEntity.Role, result.Role);
    }

    [Fact]
    public async Task GetByUserIdAndTaskIdAsync_UserTaskDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var taskId = Guid.NewGuid();
        _userTaskRepositoryMock.Setup(repo => repo.GetByUserIdAndTaskIdAsync(userId, taskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((UserTaskEntity)null);

        // Act
        var act = async () => await _userTaskService.GetByUserIdAndTaskIdAsync(userId, taskId, CancellationToken.None);

        // Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(act);
        Assert.Equal($"No user task found for userId: {userId}, taskId: {taskId}", exception.Message);
    }

    [Fact]
    public async Task GetTasksByUserIdAsync_ReturnsListOfUserTasks()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var userTasks = new List<UserTaskEntity>
        {
                new UserTaskEntity { UserId = userId, TaskId = Guid.NewGuid(), Role = TaskRole.Reviewer },
                new UserTaskEntity { UserId = userId, TaskId = Guid.NewGuid(), Role = TaskRole.Assignee }
        };

        _userTaskRepositoryMock.Setup(repo => repo.GetTasksByUserIdAsync(userId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(userTasks);

        // Act
        var result = await _userTaskService.GetTasksByUserIdAsync(userId, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Equal(userTasks[0].TaskId, result.First().TaskId);
        Assert.Equal(userTasks[1].TaskId, result.Last().TaskId);
    }

    [Fact]
    public async Task GetUsersByTaskIdAsync_ReturnsListOfUserTasks()
    {
        // Arrange
        var taskId = Guid.NewGuid();
        var userTasks = new List<UserTaskEntity>
        {
                new UserTaskEntity { UserId = Guid.NewGuid(), TaskId = taskId, Role = TaskRole.Reviewer },
                new UserTaskEntity { UserId = Guid.NewGuid(), TaskId = taskId, Role = TaskRole.Assignee }
        };

        _userTaskRepositoryMock.Setup(repo => repo.GetUsersByTaskIdAsync(taskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(userTasks);

        // Act
        var result = await _userTaskService.GetUsersByTaskIdAsync(taskId, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Equal(userTasks[0].UserId, result.First().UserId);
        Assert.Equal(userTasks[1].UserId, result.Last().UserId);
    }

    [Fact]
    public async Task GetAll_ShouldReturnMappedUserTaskDtos()
    {
        // Arrange
        var cancellationToken = CancellationToken.None;
        var userTasks = new List<UserTaskEntity> { new UserTaskEntity() };
        var userTaskDtos = new List<UserTaskDto> { new UserTaskDto() };

        _userTaskRepositoryMock.Setup(repo => repo.GetAll(cancellationToken)).ReturnsAsync(userTasks);
        _mapperMock.Setup(mapper => mapper.Map<IEnumerable<UserTaskDto>>(userTasks)).Returns(userTaskDtos);

        // Act
        var result = await _userTaskService.GetAll(cancellationToken);

        Assert.Equal(userTaskDtos.Count, result.Count());
        for (int i = 0; i < userTaskDtos.Count; i++)
        {
            Assert.Equal(userTaskDtos[i].TaskId, result.ElementAt(i).TaskId);
            Assert.Equal(userTaskDtos[i].UserId, result.ElementAt(i).UserId);
            Assert.Equal(userTaskDtos[i].Role, result.ElementAt(i).Role);
        }
    }

    [Fact]
    public async Task Update_UserTaskExists_UpdatesUserTask()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var taskId = Guid.NewGuid();
        var existingUserTask = new UserTaskEntity
        {
            UserId = userId,
            TaskId = taskId,
            Role = TaskRole.Reviewer
        };
        var updateDto = new CreateUserTaskDto
        {
            Role = TaskRole.Assignee
        };

        _userTaskRepositoryMock.Setup(repo => repo.GetByUserIdAndTaskIdAsync(userId, taskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingUserTask);

        // Act
        var result = await _userTaskService.Update(userId, taskId, updateDto, CancellationToken.None);

        // Assert
        _userTaskRepositoryMock.Verify(repo => repo.Update(existingUserTask, It.IsAny<CancellationToken>()), Times.Once);
        Assert.Equal(TaskRole.Assignee, existingUserTask.Role);
    }

    [Fact]
    public async Task Update_UserTaskDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var taskId = Guid.NewGuid();
        var updateDto = new CreateUserTaskDto { Role = TaskRole.Assignee };

        _userTaskRepositoryMock.Setup(repo => repo.GetByUserIdAndTaskIdAsync(userId, taskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((UserTaskEntity)null);

        // Act
        var act = async () => await _userTaskService.Update(userId, taskId, updateDto, CancellationToken.None);

        // Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(act);
        Assert.Equal($"No user task found for userId: {userId}, taskId: {taskId}", exception.Message);
    }

    [Fact]
    public async Task Delete_UserTaskExists_DeletesUserTask()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var taskId = Guid.NewGuid();
        var existingUserTask = new UserTaskEntity
        {
            UserId = userId,
            TaskId = taskId,
            Role = TaskRole.Assignee
        };

        _userTaskRepositoryMock.Setup(repo => repo.GetByUserIdAndTaskIdAsync(userId, taskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingUserTask);

        // Act
        await _userTaskService.Delete(userId, taskId, CancellationToken.None);

        // Assert
        _userTaskRepositoryMock.Verify(repo => repo.Delete(existingUserTask, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task Delete_UserTaskDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var taskId = Guid.NewGuid();
        _userTaskRepositoryMock.Setup(repo => repo.GetByUserIdAndTaskIdAsync(userId, taskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((UserTaskEntity)null);

        // Act
        var act = async () => await _userTaskService.Delete(userId, taskId, CancellationToken.None);

        // Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(act);
        Assert.Equal($"No user task found for userId: {userId}, taskId: {taskId}", exception.Message);
    }
}

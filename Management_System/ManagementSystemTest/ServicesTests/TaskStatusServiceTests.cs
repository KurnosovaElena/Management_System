using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Exceptions;
using BLL.Services.Implementation;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Moq;

namespace ManagementSystemTest.ServicesTests;

public class TaskStatusServiceTests
{
    private readonly Mock<ITaskStatusRepository> _taskStatusRepositoryMock;
    private readonly IMapper _mapper;
    private readonly TaskStatusService _taskStatusService;

    public TaskStatusServiceTests()
    {
        _taskStatusRepositoryMock = new Mock<ITaskStatusRepository>();
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<CreateTaskStatusDTO, TaskStatusEntity>();
            cfg.CreateMap<TaskStatusEntity, TaskStatusDTO>();
        });
        _mapper = config.CreateMapper();
        _taskStatusService = new TaskStatusService(_taskStatusRepositoryMock.Object, _mapper);
    }

    [Fact]
    public async Task Add_ValidTaskStatus_AddsAndReturnsTaskStatusDTO()
    {
        // Arrange
        var createTaskStatusDto = new CreateTaskStatusDTO
        {
            Name = "In Progress",
            Description = "Tasks that are currently being worked on",
            BoardId = Guid.NewGuid()
        };

        var taskStatusEntity = new TaskStatusEntity
        {
            Name = createTaskStatusDto.Name,
            Description = createTaskStatusDto.Description,
            BoardId = createTaskStatusDto.BoardId
        };

        _taskStatusRepositoryMock.Setup(repo => repo.Add(It.IsAny<TaskStatusEntity>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(taskStatusEntity);

        // Act
        var result = await _taskStatusService.Add(createTaskStatusDto, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("In Progress", result.Name);
        Assert.Equal("Tasks that are currently being worked on", result.Description);
        Assert.Equal(createTaskStatusDto.BoardId, result.BoardId);
    }

    [Fact]
    public async Task GetById_TaskStatusExists_ReturnsTaskStatusDTO()
    {
        // Arrange
        var taskStatusId = Guid.NewGuid();
        var taskStatusEntity = new TaskStatusEntity
        {
            Id = taskStatusId,
            Name = "Completed",
            Description = "Tasks that have been completed",
            BoardId = Guid.NewGuid()
        };

        _taskStatusRepositoryMock.Setup(repo => repo.GetById(taskStatusId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(taskStatusEntity);

        // Act
        var result = await _taskStatusService.GetById(taskStatusId, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(taskStatusEntity.Name, result.Name);
        Assert.Equal(taskStatusEntity.Description, result.Description);
        Assert.Equal(taskStatusEntity.BoardId, result.BoardId);
    }

    [Fact]
    public async Task GetById_TaskStatusDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var taskStatusId = Guid.NewGuid();
        _taskStatusRepositoryMock.Setup(repo => repo.GetById(taskStatusId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((TaskStatusEntity?)null);

        // Act
        var act = async () => await _taskStatusService.GetById(taskStatusId, CancellationToken.None);

        // Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(act);
        Assert.Equal("No task status found", exception.Message);
    }

    [Fact]
    public async Task GetAll_ReturnsListOfTaskStatuses()
    {
        // Arrange
        var taskStatuses = new List<TaskStatusEntity>
            {
                new TaskStatusEntity { Name = "To Do", Description = "Tasks to be done", BoardId = Guid.NewGuid() },
                new TaskStatusEntity { Name = "In Progress", Description = "Tasks currently being worked on", BoardId = Guid.NewGuid() }
            };

        _taskStatusRepositoryMock.Setup(repo => repo.GetAll(It.IsAny<CancellationToken>()))
            .ReturnsAsync(taskStatuses);

        // Act
        var result = await _taskStatusService.GetAll(CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Equal("To Do", result.First().Name);
        Assert.Equal("In Progress", result.Last().Name);
    }

    [Fact]
    public async Task Update_TaskStatusExists_UpdatesTaskStatus()
    {
        // Arrange
        var taskStatusId = Guid.NewGuid();
        var existingTaskStatus = new TaskStatusEntity
        {
            Id = taskStatusId,
            Name = "Old Status",
            Description = "Old Description",
            BoardId = Guid.NewGuid()
        };
        var updateDto = new CreateTaskStatusDTO
        {
            Name = "Updated Status",
            Description = "Updated Description",
            BoardId = existingTaskStatus.BoardId
        };

        _taskStatusRepositoryMock.Setup(repo => repo.GetById(taskStatusId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingTaskStatus);

        // Act
        var result = await _taskStatusService.Update(taskStatusId, updateDto, CancellationToken.None);

        // Assert
        _taskStatusRepositoryMock.Verify(repo => repo.Update(existingTaskStatus, It.IsAny<CancellationToken>()), Times.Once);
        Assert.Equal("Updated Status", existingTaskStatus.Name);
        Assert.Equal("Updated Description", existingTaskStatus.Description);
    }

    [Fact]
    public async Task Update_TaskStatusDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var taskStatusId = Guid.NewGuid();
        var updateDto = new CreateTaskStatusDTO { Name = "New Name", Description = "New Description", BoardId = Guid.NewGuid() };

        _taskStatusRepositoryMock.Setup(repo => repo.GetById(taskStatusId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((TaskStatusEntity?)null);

        // Act
        var act = async () => await _taskStatusService.Update(taskStatusId, updateDto, CancellationToken.None);

        // Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(act);
        Assert.Equal("No task status found", exception.Message);
    }

    [Fact]
    public async Task Delete_TaskStatusExists_DeletesTaskStatus()
    {
        // Arrange
        var taskStatusId = Guid.NewGuid();
        var existingTaskStatus = new TaskStatusEntity
        {
            Id = taskStatusId,
            Name = "Task Status to Delete",
            Description = "This task status will be deleted.",
            BoardId = Guid.NewGuid()
        };

        _taskStatusRepositoryMock.Setup(repo => repo.GetById(taskStatusId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingTaskStatus);

        // Act
        await _taskStatusService.Delete(taskStatusId, CancellationToken.None);

        // Assert
        _taskStatusRepositoryMock.Verify(repo => repo.Delete(existingTaskStatus, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task Delete_TaskStatusDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var taskStatusId = Guid.NewGuid();
        _taskStatusRepositoryMock.Setup(repo => repo.GetById(taskStatusId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((TaskStatusEntity?)null);

        // Act
        var act = async () => await _taskStatusService.Delete(taskStatusId, CancellationToken.None);

        // Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(act);
        Assert.Equal("No task status found", exception.Message);
    }
}

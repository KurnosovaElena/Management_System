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

public class TasksServiceTests
{
    private readonly Mock<ITaskRepository> _taskRepositoryMock;
    private readonly IMapper _mapper;
    private readonly TasksService _tasksService;

    public TasksServiceTests()
    {
        _taskRepositoryMock = new Mock<ITaskRepository>();
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<CreateTasksDTO, TaskEntity>();
            cfg.CreateMap<TaskEntity, TasksDTO>();
        });
        _mapper = config.CreateMapper();
        _tasksService = new TasksService(_taskRepositoryMock.Object, _mapper);
    }

    [Fact]
    public async Task Add_ValidTask_AddsAndReturnsTaskDTO()
    {
        // Arrange
        var createTaskDto = new CreateTasksDTO
        {
            Name = "Task 1",
            Description = "Description for Task 1",
            Priority = TaskPriority.High,
            TaskEstimation = TaskEstimation.Hour,
            TableId = Guid.NewGuid()
        };

        var taskEntity = new TaskEntity
        {
            Name = createTaskDto.Name,
            Description = createTaskDto.Description,
            Priority = createTaskDto.Priority,
            TaskEstimation = createTaskDto.TaskEstimation,
            TableId = createTaskDto.TableId
        };

        _taskRepositoryMock.Setup(repo => repo.Add(It.IsAny<TaskEntity>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(taskEntity);

        // Act
        var result = await _tasksService.Add(createTaskDto, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("Task 1", result.Name);
        Assert.Equal("Description for Task 1", result.Description);
        Assert.Equal(TaskPriority.High, result.Priority);
        Assert.Equal(TaskEstimation.Hour, result.TaskEstimation);
        Assert.Equal(createTaskDto.TableId, result.TableId);
    }

    [Fact]
    public async Task GetById_TaskExists_ReturnsTaskDTO()
    {
        // Arrange
        var taskId = Guid.NewGuid();
        var taskEntity = new TaskEntity
        {
            Id = taskId,
            Name = "Task 2",
            Description = "Description for Task 2",
            Priority = TaskPriority.Medium,
            TaskEstimation = TaskEstimation.Hour,
            TableId = Guid.NewGuid()
        };

        _taskRepositoryMock.Setup(repo => repo.GetById(taskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(taskEntity);

        // Act
        var result = await _tasksService.GetById(taskId, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(taskEntity.Name, result.Name);
        Assert.Equal(taskEntity.Description, result.Description);
        Assert.Equal(taskEntity.Priority, result.Priority);
        Assert.Equal(taskEntity.TaskEstimation, result.TaskEstimation);
        Assert.Equal(taskEntity.TableId, result.TableId);
    }

    [Fact]
    public async Task GetById_TaskDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var taskId = Guid.NewGuid();
        _taskRepositoryMock.Setup(repo => repo.GetById(taskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((TaskEntity)null);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(() =>
            _tasksService.GetById(taskId, CancellationToken.None));
        Assert.Equal("No task found", exception.Message);
    }

    [Fact]
    public async Task GetAll_ReturnsListOfTasks()
    {
        // Arrange
        var tasks = new List<TaskEntity>
            {
                new TaskEntity { Name = "Task 1", Description = "Description for Task 1", Priority = TaskPriority.Low, TaskEstimation = TaskEstimation.Hour, TableId = Guid.NewGuid() },
                new TaskEntity { Name = "Task 2", Description = "Description for Task 2", Priority = TaskPriority.High, TaskEstimation = TaskEstimation.Hour, TableId = Guid.NewGuid() }
            };

        _taskRepositoryMock.Setup(repo => repo.GetAll(It.IsAny<CancellationToken>()))
            .ReturnsAsync(tasks);

        // Act
        var result = await _tasksService.GetAll(CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Equal("Task 1", result.First().Name);
        Assert.Equal("Task 2", result.Last().Name);
    }

    [Fact]
    public async Task Update_TaskExists_UpdatesTask()
    {
        // Arrange
        var taskId = Guid.NewGuid();
        var existingTask = new TaskEntity
        {
            Id = taskId,
            Name = "Old Task Name",
            Description = "Old Description",
            Priority = TaskPriority.Low,
            TaskEstimation = TaskEstimation.Hour,
            TableId = Guid.NewGuid()
        };
        var updateDto = new CreateTasksDTO
        {
            Name = "Updated Task Name",
            Description = "Updated Description",
            Priority = TaskPriority.High,
            TaskEstimation = TaskEstimation.Hour,
            TableId = existingTask.TableId
        };

        _taskRepositoryMock.Setup(repo => repo.GetById(taskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingTask);

        // Act
        var result = await _tasksService.Update(taskId, updateDto, CancellationToken.None);

        // Assert
        _taskRepositoryMock.Verify(repo => repo.Update(existingTask, It.IsAny<CancellationToken>()), Times.Once);
        Assert.Equal("Updated Task Name", existingTask.Name);
        Assert.Equal("Updated Description", existingTask.Description);
        Assert.Equal(TaskPriority.High, existingTask.Priority);
        Assert.Equal(TaskEstimation.Hour, existingTask.TaskEstimation);
    }

    [Fact]
    public async Task Update_TaskDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var taskId = Guid.NewGuid();
        var updateDto = new CreateTasksDTO { Name = "New Name", Description = "New Description", Priority = TaskPriority.Medium, TaskEstimation = TaskEstimation.Hour, TableId = Guid.NewGuid() };

        _taskRepositoryMock.Setup(repo => repo.GetById(taskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((TaskEntity)null);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(() =>
            _tasksService.Update(taskId, updateDto, CancellationToken.None));
        Assert.Equal("No task found", exception.Message);
    }

    [Fact]
    public async Task Delete_TaskExists_DeletesTask()
    {
        // Arrange
        var taskId = Guid.NewGuid();
        var existingTask = new TaskEntity
        {
            Id = taskId,
            Name = "Task to Delete",
            Description = "This task will be deleted.",
            Priority = TaskPriority.Low,
            TaskEstimation = TaskEstimation.Hour,
            TableId = Guid.NewGuid()
        };

        _taskRepositoryMock.Setup(repo => repo.GetById(taskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingTask);

        // Act
        await _tasksService.Delete(taskId, CancellationToken.None);

        // Assert
        _taskRepositoryMock.Verify(repo => repo.Delete(existingTask, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task Delete_TaskDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var taskId = Guid.NewGuid();
        _taskRepositoryMock.Setup(repo => repo.GetById(taskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((TaskEntity)null);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(() =>
            _tasksService.Delete(taskId, CancellationToken.None));
        Assert.Equal("No task found", exception.Message);
    }
}

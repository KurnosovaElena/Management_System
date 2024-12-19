using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Exceptions;
using BLL.Services.Implementation;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Moq;

namespace ManagementSystemTest.ServicesTests;

public class SubtaskServiceTests
{
    private readonly Mock<ISubtaskRepository> _subtaskRepositoryMock;
    private readonly IMapper _mapper;
    private readonly SubtaskService _subtaskService;

    public SubtaskServiceTests()
    {
        _subtaskRepositoryMock = new Mock<ISubtaskRepository>();
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<CreateSubtaskDTO, SubtaskEntity>();
            cfg.CreateMap<SubtaskEntity, SubtaskDTO>();
        });
        _mapper = config.CreateMapper();
        _subtaskService = new SubtaskService(_subtaskRepositoryMock.Object, _mapper);
    }

    [Fact]
    public async Task Add_ValidSubtask_AddsAndReturnsSubtaskDTO()
    {
        // Arrange
        var createSubtaskDto = new CreateSubtaskDTO
        {
            Name = "Subtask 1",
            Description = "Description for Subtask 1",
        };
        var subtaskEntity = new SubtaskEntity
        {
            Name = createSubtaskDto.Name,
            Description = createSubtaskDto.Description,
        };

        _subtaskRepositoryMock.Setup(repo => repo.Add(It.IsAny<SubtaskEntity>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(subtaskEntity);

        // Act
        var result = await _subtaskService.Add(createSubtaskDto, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("Subtask 1", result.Name);
        Assert.Equal("Description for Subtask 1", result.Description);
    }

    [Fact]
    public async Task GetById_SubtaskExists_ReturnsSubtaskDTO()
    {
        // Arrange
        var subtaskId = Guid.NewGuid();
        var subtaskEntity = new SubtaskEntity
        {
            Name = "Subtask 2",
            Description = "Description for Subtask 2",
            TaskId = Guid.NewGuid() // Assuming TaskId is required
        };

        _subtaskRepositoryMock.Setup(repo => repo.GetById(subtaskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(subtaskEntity);

        // Act
        var result = await _subtaskService.GetById(subtaskId, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(subtaskEntity.Name, result.Name);
        Assert.Equal(subtaskEntity.Description, result.Description);
    }

    [Fact]
    public async Task GetById_SubtaskDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var subtaskId = Guid.NewGuid();
        _subtaskRepositoryMock.Setup(repo => repo.GetById(subtaskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((SubtaskEntity)null);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(() =>
            _subtaskService.GetById(subtaskId, CancellationToken.None));
        Assert.Equal("No subtask found", exception.Message);
    }

    [Fact]
    public async Task GetAll_ReturnsListOfSubtasks()
    {
        // Arrange
        var subtasks = new List<SubtaskEntity>
            {
                new SubtaskEntity { Name = "Subtask 1", Description = "Description for Subtask 1", TaskId = Guid.NewGuid() },
                new SubtaskEntity { Name = "Subtask 2", Description = "Description for Subtask 2", TaskId = Guid.NewGuid() }
            };

        _subtaskRepositoryMock.Setup(repo => repo.GetAll(It.IsAny<CancellationToken>()))
            .ReturnsAsync(subtasks);

        // Act
        var result = await _subtaskService.GetAll(CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Equal("Subtask 1", result.First().Name);
        Assert.Equal("Subtask 2", result.Last().Name);
    }

    [Fact]
    public async Task Update_SubtaskExists_UpdatesSubtask()
    {
        // Arrange
        var subtaskId = Guid.NewGuid();
        var existingSubtask = new SubtaskEntity
        {
            Id = subtaskId,
            Name = "Old Name",
            Description = "Old Description",
            TaskId = Guid.NewGuid() // Assuming TaskId is required
        };
        var updateDto = new CreateSubtaskDTO
        {
            Name = "Updated Name",
            Description = "Updated Description",
        };

        _subtaskRepositoryMock.Setup(repo => repo.GetById(subtaskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingSubtask);

        // Act
        var result = await _subtaskService.Update(subtaskId, updateDto, CancellationToken.None);

        // Assert
        _subtaskRepositoryMock.Verify(repo => repo.Update(existingSubtask, It.IsAny<CancellationToken>()), Times.Once);
        Assert.Equal("Updated Name", existingSubtask.Name);
        Assert.Equal("Updated Description", existingSubtask.Description);
    }

    [Fact]
    public async Task Update_SubtaskDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var subtaskId = Guid.NewGuid();
        var updateDto = new CreateSubtaskDTO { Name = "New Name", Description = "New Description"};

        _subtaskRepositoryMock.Setup(repo => repo.GetById(subtaskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((SubtaskEntity)null);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(() =>
            _subtaskService.Update(subtaskId, updateDto, CancellationToken.None));
        Assert.Equal("No subtask found", exception.Message);
    }

    [Fact]
    public async Task Delete_SubtaskExists_DeletesSubtask()
    {
        // Arrange
        var subtaskId = Guid.NewGuid();
        var existingSubtask = new SubtaskEntity
        {
            Id = subtaskId,
            Name = "Subtask to Delete",
            Description = "This subtask will be deleted.",
            TaskId = Guid.NewGuid() // Assuming TaskId is required
        };

        _subtaskRepositoryMock.Setup(repo => repo.GetById(subtaskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingSubtask);

        // Act
        await _subtaskService.Delete(subtaskId, CancellationToken.None);

        // Assert
        _subtaskRepositoryMock.Verify(repo => repo.Delete(existingSubtask, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task Delete_SubtaskDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var subtaskId = Guid.NewGuid();
        _subtaskRepositoryMock.Setup(repo => repo.GetById(subtaskId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((SubtaskEntity)null);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(() =>
            _subtaskService.Delete(subtaskId, CancellationToken.None));
        Assert.Equal("No subtask found", exception.Message);
    }
}

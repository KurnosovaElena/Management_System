using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Exceptions;
using BLL.Services.Implementation;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Moq;

namespace ManagementSystemTest.ServicesTests;

public class LabelServiceTests
{
    private readonly Mock<ILabelRepository> _labelRepositoryMock;
    private readonly IMapper _mapper;
    private readonly LabelService _labelService;

    public LabelServiceTests()
    {
        _labelRepositoryMock = new Mock<ILabelRepository>();
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<CreateLabelDto, LabelEntity>();
            cfg.CreateMap<LabelEntity, LabelDto>();
        });
        _mapper = config.CreateMapper();
        _labelService = new LabelService(_labelRepositoryMock.Object, _mapper);
    }

    [Fact]
    public async Task Add_ValidLabel_AddsAndReturnsLabelDTO()
    {
        // Arrange
        var createLabelDto = new CreateLabelDto
        {
            Name = "Urgent",
            Description = "Tasks that need immediate attention"
        };
        var labelEntity = new LabelEntity
        {
            Name = createLabelDto.Name,
            Description = createLabelDto.Description
        };

        _labelRepositoryMock.Setup(repo => repo.Add(It.IsAny<LabelEntity>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(labelEntity);

        // Act
        var result = await _labelService.Add(createLabelDto, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("Urgent", result.Name);
        Assert.Equal("Tasks that need immediate attention", result.Description);
    }

    [Fact]
    public async Task GetById_LabelExists_ReturnsLabelDTO()
    {
        // Arrange
        var labelId = Guid.NewGuid();
        var labelEntity = new LabelEntity
        {
            Name = "Important",
            Description = "Tasks that are important but not urgent",
            Tasks = new List<TaskEntity>() // Initialize if needed
        };

        _labelRepositoryMock.Setup(repo => repo.GetById(labelId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(labelEntity); // Adjust this line if necessary

        // Act
        var result = await _labelService.GetById(labelId, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(labelEntity.Name, result.Name);
        Assert.Equal(labelEntity.Description, result.Description);
    }

    [Fact]
    public async Task GetById_LabelDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var labelId = Guid.NewGuid();
        _labelRepositoryMock.Setup(repo => repo.GetById(labelId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((LabelEntity?)null); // Adjust this line if necessary

        // Act
        var act = async () => await _labelService.GetById(labelId, CancellationToken.None);

        // Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(act);
        Assert.Equal("No label found", exception.Message);
    }

    [Fact]
    public async Task GetAll_ReturnsListOfLabels()
    {
        // Arrange
        var labels = new List<LabelEntity>
            {
                new LabelEntity { Name = "Low Priority", Description = "Tasks with low priority" },
                new LabelEntity { Name = "High Priority", Description = "Tasks with high priority" }
            };

        _labelRepositoryMock.Setup(repo => repo.GetAll(It.IsAny<CancellationToken>()))
            .ReturnsAsync(labels); // Adjust this line if necessary

        // Act
        var result = await _labelService.GetAll(CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Equal("Low Priority", result.First().Name);
        Assert.Equal("High Priority", result.Last().Name);
    }

    [Fact]
    public async Task Update_LabelExists_UpdatesLabel()
    {
        // Arrange
        var labelId = Guid.NewGuid();
        var existingLabel = new LabelEntity
        {
            Id = labelId,
            Name = "Old Name",
            Description = "Old Description"
        };
        var updateDto = new CreateLabelDto
        {
            Name = "Updated Name",
            Description = "Updated Description"
        };

        _labelRepositoryMock.Setup(repo => repo.GetById(labelId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingLabel); // Adjust this line if necessary

        // Act
        var result = await _labelService.Update(labelId, updateDto, CancellationToken.None);

        // Assert
        _labelRepositoryMock.Verify(repo => repo.Update(existingLabel, It.IsAny<CancellationToken>()), Times.Once);
        Assert.Equal("Updated Name", existingLabel.Name);
        Assert.Equal("Updated Description", existingLabel.Description);
    }

    [Fact]
    public async Task Update_LabelDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var labelId = Guid.NewGuid();
        var updateDto = new CreateLabelDto { Name = "New Name", Description = "New Description" };

        _labelRepositoryMock.Setup(repo => repo.GetById(labelId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((LabelEntity?)null); // Adjust this line if necessary

        // Act
        var act = async () => await _labelService.Update(labelId, updateDto, CancellationToken.None);

        // Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(act);
        Assert.Equal("No label found", exception.Message);
    }

    [Fact]
    public async Task Delete_LabelExists_DeletesLabel()
    {
        // Arrange
        var labelId = Guid.NewGuid();
        var existingLabel = new LabelEntity
        {
            Id = labelId,
            Name = "Label to Delete",
            Description = "This label will be deleted."
        };

        _labelRepositoryMock.Setup(repo => repo.GetById(labelId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingLabel); // Adjust this line if necessary

        // Act
        await _labelService.Delete(labelId, CancellationToken.None);

        // Assert
        _labelRepositoryMock.Verify(repo => repo.Delete(existingLabel, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task Delete_LabelDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var labelId = Guid.NewGuid();
        _labelRepositoryMock.Setup(repo => repo.GetById(labelId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((LabelEntity?)null); // Adjust this line if necessary

        // Act
        var act = async () => await _labelService.Delete(labelId, CancellationToken.None);

        // Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(act);
        Assert.Equal("No label found", exception.Message);
    }
}

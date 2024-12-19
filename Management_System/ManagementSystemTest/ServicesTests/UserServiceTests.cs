using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Exceptions;
using BLL.Services.Implementation;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Moq;

namespace ManagementSystemTest.ServicesTests;

public class UserServiceTests
{
    private readonly Mock<IUserRepository> _userRepositoryMock;
    private readonly IMapper _mapper;
    private readonly UserService _userService;

    public UserServiceTests()
    {
        _userRepositoryMock = new Mock<IUserRepository>();
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<CreateUserDTO, UserEntity>();
            cfg.CreateMap<UserEntity, UserDTO>();
        });
        _mapper = config.CreateMapper();
        _userService = new UserService(_userRepositoryMock.Object, _mapper);
    }

    [Fact]
    public async Task Add_ValidUser_AddsAndReturnsUserDTO()
    {
        // Arrange
        var createUserDto = new CreateUserDTO
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com"
        };

        var userEntity = new UserEntity
        {
            FirstName = createUserDto.FirstName,
            LastName = createUserDto.LastName,
            Email = createUserDto.Email
        };

        _userRepositoryMock.Setup(repo => repo.Add(It.IsAny<UserEntity>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(userEntity);

        // Act
        var result = await _userService.Add(createUserDto, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("John", result.FirstName);
        Assert.Equal("Doe", result.LastName);
        Assert.Equal("john.doe@example.com", result.Email);
    }

    [Fact]
    public async Task GetById_UserExists_ReturnsUserDTO()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var userEntity = new UserEntity
        {
            FirstName = "Jane",
            LastName = "Smith",
            Email = "jane.smith@example.com"
        };

        _userRepositoryMock.Setup(repo => repo.GetById(userId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(userEntity);

        // Act
        var result = await _userService.GetById(userId, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(userEntity.FirstName, result.FirstName);
        Assert.Equal(userEntity.LastName, result.LastName);
        Assert.Equal(userEntity.Email, result.Email);
    }

    [Fact]
    public async Task GetAll_ReturnsListOfUsers()
    {
        // Arrange
        var users = new List<UserEntity>
            {
                new UserEntity { FirstName = "Alice", LastName = "Johnson", Email = "alice.johnson@example.com" },
                new UserEntity { FirstName = "Bob", LastName = "Brown", Email = "bob.brown@example.com" }
            };

        _userRepositoryMock.Setup(repo => repo.GetAll(It.IsAny<CancellationToken>()))
            .ReturnsAsync(users);

        // Act
        var result = await _userService.GetAll(CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Equal("Alice", result.First().FirstName);
        Assert.Equal("Bob", result.Last().FirstName);
    }

    [Fact]
    public async Task Update_UserExists_UpdatesUser()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var existingUser = new UserEntity
        {
            Id = userId,
            FirstName = "Old Name",
            LastName = "Old Last Name",
            Email = "old.email@example.com"
        };
        var updateDto = new CreateUserDTO
        {
            FirstName = "Updated Name",
            LastName = "Updated Last Name",
            Email = "updated.email@example.com"
        };

        _userRepositoryMock.Setup(repo => repo.GetById(userId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingUser);

        // Act
        var result = await _userService.Update(userId, updateDto, CancellationToken.None);

        // Assert
        _userRepositoryMock.Verify(repo => repo.Update(existingUser, It.IsAny<CancellationToken>()), Times.Once);
        Assert.Equal("Updated Name", existingUser.FirstName);
        Assert.Equal("Updated Last Name", existingUser.LastName);
        Assert.Equal("updated.email@example.com", existingUser.Email);
    }

    [Fact]
    public async Task Update_UserDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var updateDto = new CreateUserDTO { FirstName = "New Name", LastName = "New Last Name", Email = "new.email@example.com" };

        _userRepositoryMock.Setup(repo => repo.GetById(userId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((UserEntity)null);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(() =>
            _userService.Update(userId, updateDto, CancellationToken.None));
        Assert.Equal("No user found", exception.Message);
    }

    [Fact]
    public async Task Delete_UserExists_DeletesUser()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var existingUser = new UserEntity
        {
            Id = userId,
            FirstName = "User to Delete",
            LastName = "Last Name",
            Email = "delete.user@example.com"
        };

        _userRepositoryMock.Setup(repo => repo.GetById(userId, It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingUser);

        // Act
        await _userService.Delete(userId, CancellationToken.None);

        // Assert
        _userRepositoryMock.Verify(repo => repo.Delete(existingUser, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task Delete_UserDoesNotExist_ThrowsNotFoundException()
    {
        // Arrange
        var userId = Guid.NewGuid();
        _userRepositoryMock.Setup(repo => repo.GetById(userId, It.IsAny<CancellationToken>()))
            .ReturnsAsync((UserEntity)null);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(() =>
            _userService.Delete(userId, CancellationToken.None));
        Assert.Equal("No user found", exception.Message);
    }
}

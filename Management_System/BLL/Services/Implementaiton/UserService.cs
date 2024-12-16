using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Exceptions;
using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementation;

public class UserService(IUserRepository repository, IMapper mapper) : IUserService
{
    public async Task<UserDTO> Add(CreateUserDTO entity, CancellationToken cancellationToken)
    {
        try
        {
            var user = mapper.Map<UserEntity>(entity);
            await repository.Add(user, cancellationToken);
            var userDTO = mapper.Map<UserDTO>(user);
            return userDTO;
        }
        catch (Exception ex)
        {
            throw new ApplicationException("An error occurred while adding the user.", ex);
        }
    }

    public async Task<UserDTO> GetById(Guid id, CancellationToken cancellationToken)
    {
        var user = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No user found");

        var userDTO = mapper.Map<UserDTO>(user);

        return userDTO;
    }

    public async Task<IEnumerable<UserDTO>> GetAll(CancellationToken cancellationToken)
    {
        var users = await repository.GetAll(cancellationToken)
            ?? throw new NotFoundException("No users found");

        var usersDTO = mapper.Map<IEnumerable<UserDTO>>(users);

        return usersDTO;
    }

    public async Task<UserDTO> Update(Guid id, CreateUserDTO entity, CancellationToken cancellationToken)
    {
        var user = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No user found");

        if (entity == null)
        {
            throw new BadRequestException("Invalid user data provided.");
        }

        mapper.Map(entity, user);

        await repository.Update(user, cancellationToken);

        var userDTO = mapper.Map<UserDTO>(user);

        return userDTO;
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var user = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No user found");

        await repository.Delete(user, cancellationToken);
    }
}
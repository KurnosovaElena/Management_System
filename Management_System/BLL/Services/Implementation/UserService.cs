﻿using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Exceptions;
using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementation;

public class UserService(IUserRepository repository, IMapper mapper) : IUserService
{
    public async Task<UserDto> Add(CreateUserDto entity, CancellationToken cancellationToken)
    {
        var user = mapper.Map<UserEntity>(entity);

        await repository.Add(user, cancellationToken);

        var userDTO = mapper.Map<UserDto>(user);

        return userDTO;
    }

    public async Task<UserDto> GetById(Guid id, CancellationToken cancellationToken)
    {
        var user = await repository.GetById(id, cancellationToken);

        var userDTO = mapper.Map<UserDto>(user);

        return userDTO;
    }

    public async Task<IEnumerable<UserDto>> GetAll(CancellationToken cancellationToken)
    {
        var users = await repository.GetAll(cancellationToken)
            ?? throw new NotFoundException("No users found");

        var usersDTO = mapper.Map<IEnumerable<UserDto>>(users);

        return usersDTO;
    }

    public async Task<UserDto> Update(Guid id, CreateUserDto entity, CancellationToken cancellationToken)
    {
        if (entity is null)
        {
            throw new BadRequestException("Invalid user data provided.");
        }

        var user = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No user found");

        mapper.Map(entity, user);

        await repository.Update(user, cancellationToken);

        var userDTO = mapper.Map<UserDto>(user);

        return userDTO;
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var user = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No user found");

        await repository.Delete(user, cancellationToken);
    }
}
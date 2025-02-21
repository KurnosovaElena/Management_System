﻿using AutoMapper;
using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Exceptions;
using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementation;

public class TasksService(ITaskRepository repository, IMapper mapper) : ITasksService
{
    public async Task<TasksDto> Add(CreateTasksDto entity, CancellationToken cancellationToken)
    {
        var task = mapper.Map<TaskEntity>(entity);
        await repository.Add(task, cancellationToken);
        var taskDTO = mapper.Map<TasksDto>(task);
        return taskDTO;
    }

    public async Task<TasksDto> GetById(Guid id, CancellationToken cancellationToken)
    {
        var task = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No task found");

        var taskDTO = mapper.Map<TasksDto>(task);

        return taskDTO;
    }

    public async Task<IEnumerable<TasksDto>> GetAll(CancellationToken cancellationToken)
    {
        var tasks = await repository.GetAll(cancellationToken);

        var tasksDTO = mapper.Map<IEnumerable<TasksDto>>(tasks);

        return tasksDTO;
    }

    public async Task<TasksDto> Update(Guid id, CreateTasksDto entity, CancellationToken cancellationToken)
    {
        if (entity is null)
        {
            throw new BadRequestException("Invalid task data provided.");
        }

        var task = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No task found");

        mapper.Map(entity, task);

        await repository.Update(task, cancellationToken);

        var taskDTO = mapper.Map<TasksDto>(task);

        return taskDTO;
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var task = await repository.GetById(id, cancellationToken)
            ?? throw new NotFoundException("No task found");

        await repository.Delete(task, cancellationToken);
    }
}
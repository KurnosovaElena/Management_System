﻿using BLL.Services.Interfaсes;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers;

[ApiController]
[Route("[controller]")]

public class TaskStatusController(ITaskStatusService service) : ControllerBase 
{
    [HttpGet]
    public async Task<IEnumerable<TaskStatusEntity>> GetAll(CancellationToken cancellationToken)
    {
        var statusAll = await service.GetAll(cancellationToken);
        return statusAll;
    }

    [HttpGet("{id}")]
    public async Task<TaskStatusEntity> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var status = await service.GetById(id, cancellationToken);
        return status;
    }

    [HttpPost]
    public async Task<TaskStatusEntity> Add([FromBody] TaskStatusEntity entity, CancellationToken cancellationToken)
    {
        var status = await service.Add(entity, cancellationToken);

        return status;
    }

    [HttpPut("{id}")]
    public async Task<TaskStatusEntity> Update([FromRoute] Guid id,[FromBody] TaskStatusEntity entity, CancellationToken cancellationToken)
    {
        var status = await service.Update(id, entity, cancellationToken);
        return status;
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.Delete(id, cancellationToken);
    }
}
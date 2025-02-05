﻿using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Services.Interfaсes;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/subtasks")]
public class SubtaskController(ISubtaskService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<SubtaskDto>> GetAll(CancellationToken cancellationToken)
    {
        var subtasks = await service.GetAll(cancellationToken);
        return subtasks;
    }

    [HttpGet("{id}")]
    public async Task<SubtaskDto> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var subtask = await service.GetById(id, cancellationToken);
        return subtask;
    }

    [HttpPost]
    public async Task<SubtaskDto> Add([FromBody] CreateSubtaskDto entity, CancellationToken cancellationToken)
    {
        var subtask = await service.Add(entity, cancellationToken);
        return subtask;
    }

    [HttpPut("{id}")]
    public async Task<SubtaskDto> Update([FromRoute] Guid id, [FromBody] CreateSubtaskDto entity, CancellationToken cancellationToken)
    {
        var subtask = await service.Update(id, entity, cancellationToken);
        return subtask;
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.Delete(id, cancellationToken);
    }
}
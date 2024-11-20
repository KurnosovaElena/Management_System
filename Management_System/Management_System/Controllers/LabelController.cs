using BLL.Services.Interfaсes;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Emit;

namespace ManagementSystem.Controllers;

[ApiController]
[Route("[controller]")]

public class LabelController(ILabelService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<LabelEntity>> GetAll(CancellationToken cancellationToken)
    {
        var labels = await service.GetAll(cancellationToken);
        return labels;
    }

    [HttpGet("{id}")]
    public async Task<LabelEntity> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var label = await service.GetById(id, cancellationToken);
        return label;
    }

    [HttpPost]
    public async Task<LabelEntity> Add([FromBody] LabelEntity entity, CancellationToken cancellationToken)
    {
        var label = await service.Add(entity, cancellationToken);

        return label;
    }

    [HttpPut("{id}")]
    public async Task<LabelEntity> Update([FromRoute] Guid id,[FromBody] LabelEntity entity, CancellationToken cancellationToken)
    {
        var label = await service.Update(id, entity, cancellationToken);
        return label;
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.Delete(id, cancellationToken);
    }
}


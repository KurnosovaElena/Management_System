using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Services.Interfaсes;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/labels")]
public class LabelsController(ILabelService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<LabelDTO>> GetAll(CancellationToken cancellationToken)
    {
        var labels = await service.GetAll(cancellationToken);
        return labels;
    }

    [HttpGet("{id}")]
    public async Task<LabelDTO> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var label = await service.GetById(id, cancellationToken);
        return label;
    }

    [HttpPost]
    public async Task<LabelDTO> Add([FromBody] CreateLabelDTO entity, CancellationToken cancellationToken)
    {
        var label = await service.Add(entity, cancellationToken);
        return label;
    }

    [HttpPut("{id}")]
    public async Task<LabelDTO> Update([FromRoute] Guid id, [FromBody] CreateLabelDTO entity, CancellationToken cancellationToken)
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
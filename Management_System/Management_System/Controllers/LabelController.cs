using BLL.DTO;
using BLL.DTO.CreateDTO;
using BLL.Services.Interfaсes;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/labels")]
public class LabelsController(ILabelService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<LabelDto>> GetAll(CancellationToken cancellationToken)
    {
        var labels = await service.GetAll(cancellationToken);
        return labels;
    }

    [HttpGet("{id}")]
    public async Task<LabelDto> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var label = await service.GetById(id, cancellationToken);
        return label;
    }

    [HttpPost]
    public async Task<LabelDto> Add([FromBody] CreateLabelDto entity, CancellationToken cancellationToken)
    {
        var label = await service.Add(entity, cancellationToken);
        return label;
    }

    [HttpPut("{id}")]
    public async Task<LabelDto> Update([FromRoute] Guid id, [FromBody] CreateLabelDto entity, CancellationToken cancellationToken)
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
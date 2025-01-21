using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserMicroserviceBLL.DTO;
using UserMicroserviceBLL.DTO.CreateDTO;
using UserMicroserviceBLL.Services.Interfaces;

namespace UserMicroservice.Controllers;

[ApiController]
[Route("api/users")]
public class UserController(IUserService service) : ControllerBase
{
    [HttpGet]
    [Authorize("read:users")]
    public async Task<IEnumerable<UserDto>> GetAll(CancellationToken cancellationToken)
    {
        var users = await service.GetAll(cancellationToken);
        return users;
    }

    [HttpGet("{id}")]
    [Authorize("read:users")]
    public async Task<UserDto> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var user = await service.GetById(id, cancellationToken);
        return user;
    }

    [HttpPost]
    public async Task<UserDto> Add([FromBody] CreateUserDto entity, CancellationToken cancellationToken)
    {
        var user = await service.Add(entity, cancellationToken);
        return user;
    }

    [HttpPut("{id}")]
    public async Task<UserDto> Update([FromRoute] Guid id, [FromBody] CreateUserDto entity, CancellationToken cancellationToken)
    {
        var user = await service.Update(id, entity, cancellationToken);
        return user;
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.Delete(id, cancellationToken);
    }
}

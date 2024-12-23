using BLL.DTO.CreateDTO;

namespace BLL.DTO;

public class UserDto : CreateUserDto
{
    public Guid Id { get; set; }
}
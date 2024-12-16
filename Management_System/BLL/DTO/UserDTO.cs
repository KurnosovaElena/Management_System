using BLL.DTO.CreateDTO;

namespace BLL.DTO;

public class UserDTO : CreateUserDTO
{
    public Guid Id { get; set; }
}
using UserMicroserviceBLL.DTO.CreateDTO;

namespace UserMicroserviceBLL.DTO;

public class UserDto : CreateUserDto
{
    public Guid Id { get; set; }
}

using BLL.DTO.CreateDTO;

namespace BLL.DTO;

public class UserTaskDTO : CreateUserTaskDTO
{
    public Guid UserId { get; set; }
    public Guid TaskId { get; set; }
}

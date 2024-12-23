using BLL.DTO.CreateDTO;

namespace BLL.DTO;

public class UserTaskDto : CreateUserTaskDto
{
    public Guid UserId { get; set; }
    public Guid TaskId { get; set; }
}

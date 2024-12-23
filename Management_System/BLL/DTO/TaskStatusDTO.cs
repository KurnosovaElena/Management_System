using BLL.DTO.CreateDTO;

namespace BLL.DTO;

public class TaskStatusDto : CreateTaskStatusDto
{
    public Guid Id { get; set; }
}
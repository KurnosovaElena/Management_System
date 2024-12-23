using BLL.DTO.CreateDTO;

namespace BLL.DTO;

public class TasksDto : CreateTasksDto
{
    public Guid Id { get; set; }
}
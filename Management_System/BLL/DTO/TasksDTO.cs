using BLL.DTO.CreateDTO;

namespace BLL.DTO;

public class TasksDTO : CreateTasksDTO
{
    public Guid Id { get; set; }
}
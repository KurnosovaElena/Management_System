using DAL.Entities;

namespace BLL.DTO.CreateDTO;

public class CreateTaskStatusDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Guid BoardId { get; set; }

    public IEnumerable<TaskEntity> Tasks { get; set; } = [];
}
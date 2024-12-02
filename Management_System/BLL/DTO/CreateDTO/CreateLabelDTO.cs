using DAL.Entities;

namespace BLL.DTO.CreateDTO;

public class CreateLabelDTO
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public IEnumerable<TaskEntity> Tasks { get; set; } = [];
}


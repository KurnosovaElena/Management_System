namespace DAL.Entities;

public class BoardEntity : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public IEnumerable<TaskStatusEntity> TaskStatus { get; set; } = new List<TaskStatusEntity>();
}

namespace ManagementSystem.Entities;

public class SubtaskEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public Guid TaskId { get; set; }
}
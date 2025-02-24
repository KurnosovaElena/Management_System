using DAL.Enums;

namespace DAL.Entities;

public class UserTaskEntity : BaseEntity
{
    public Guid UserId { get; set; }
    public Guid TaskId { get; set; }

    public TaskEntity Task { get; set; } = null!;
    public TaskRole Role { get; set; }
}

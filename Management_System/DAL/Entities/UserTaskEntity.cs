using DAL.Enums;

namespace DAL.Entities;

public class UserTaskEntity : Entity
{
    public Guid UserId { get; set; }
    public Guid TaskId { get; set; }
    public UserEntity User { get; set; } = null!;
    public TaskEntity Task { get; set; } = null!;
    public TaskRole Role { get; set; }
}
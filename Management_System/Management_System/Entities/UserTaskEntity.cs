using ManagementSystem.Enums;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Entities;

[PrimaryKey(nameof(UserId), additionalPropertyNames: [nameof(TaskId)])]
public class UserTaskEntity
{
    public Guid UserId { get; set; }
    public Guid TaskId { get; set; }
    public UserEntity User { get; set; } = null!;
    public TaskEntity Task { get; set; } = null!;
    public TaskRole Role { get; set; }
}
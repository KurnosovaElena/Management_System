using DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace DAL.Entities;

public class UserTaskEntity
{
    public Guid UserId { get; set; }
    public Guid TaskId { get; set; }
    public UserEntity User { get; set; } = null!;
    public TaskEntity Task { get; set; } = null!;
    public TaskRole Role { get; set; }
}
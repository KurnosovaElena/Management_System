using ManagementSystem.Enums;

namespace ManagementSystem.Entities
{
    public class UserTask
    {
        public Guid UserId { get; set; }
        public Guid TaskId { get; set; }
        public User User { get; set; } = null!;
        public Task Task { get; set; } = null!;
        public TaskRole Role { get; set; }
    }
}

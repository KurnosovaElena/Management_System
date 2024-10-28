using ManagementSystem.Enums;

namespace ManagementSystem.Entities
{
    public class UserTask
    {
        public Guid UserId { get; set; }
        public Guid TaskId { get; set; }
        public TaskRole Role { get; set; }
    }
}

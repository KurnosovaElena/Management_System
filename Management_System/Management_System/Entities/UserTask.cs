using Management_System.Enums;

namespace Management_System.Entities
{
    public class UserTask
    {
        public Guid UserId { get; set; }
        public Guid TaskId { get; set; }
        public TaskRole Role { get; set; }
    }
}

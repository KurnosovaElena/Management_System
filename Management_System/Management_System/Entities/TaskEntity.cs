using ManagementSystem.Enums;
using System.Xml.Linq;

namespace ManagementSystem.Entities
{
    public class TaskEntity
    {
        public Guid Id { get; set; }

        public int SerialNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public TaskPriority Priority { get; set; }
        public TaskEstimation TaskEstimation { get; set; }
        public Guid TableId { get; set; }

        public IEnumerable<SubtaskEntity> Subtasks { get; set; } = [];
        public IEnumerable<UserTaskEntity> UserTasks { get; set; } = [];
    }
}

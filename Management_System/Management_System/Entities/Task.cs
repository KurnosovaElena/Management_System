using Management_System.Enums;
using System.Xml.Linq;

namespace Management_System.Entities
{
    public class Task
    {
        public Guid Id { get; set; }

        public int SerialNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public TaskPriority Priority { get; set; }
        public TaskEstimation TaskEstimation { get; set; }
        public Guid TableId { get; set; }

        public IEnumerable<Subtask>? Subtasks { get; set; }
        public IEnumerable<UserTask>? UserTasks { get; set; }
    }
}

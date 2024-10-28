namespace ManagementSystem.Entities
{
    public class Label
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public IEnumerable<TaskEntity> Tasks { get; set; } = [];

    }
}

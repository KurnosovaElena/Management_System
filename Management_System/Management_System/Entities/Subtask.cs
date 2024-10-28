namespace Management_System.Entities
{
    public class Subtask
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid TaskId { get; set; }
    }
}

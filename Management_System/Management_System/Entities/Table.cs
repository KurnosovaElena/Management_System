namespace Management_System.Entities
{
    public class Table
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid BoardId { get; set; }
        public IEnumerable<Task> Tasks { get; set; } = [];
    }
}
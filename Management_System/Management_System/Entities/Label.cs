namespace Management_System.Entities
{
    public class Label
    {
        public int Guid { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description {  get; set; } = string.Empty;

        public IEnumerable<Task>? Tasks { get; set; }

    }
}

namespace ManagementSystem.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public IEnumerable<UserBoard> UserBoards { get; set; } = [];
        public IEnumerable<UserTask> UserTasks { get; set; } = [];
    }
}

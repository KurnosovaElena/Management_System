namespace ManagementSystem.Entities
{
    public class UserBoard
    {
        public Guid UserId { get; set; }
        public Guid BoardId { get; set; }

        public User User { get; set; } = null!;
        public Board Board { get; set; } = null!;
    }
}

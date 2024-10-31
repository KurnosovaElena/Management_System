namespace ManagementSystem.Entities
{
    public class UserBoardEntity
    {
        public Guid UserId { get; set; }
        public Guid BoardId { get; set; }

        public UserEntity User { get; set; } = null!;
        public BoardEntity Board { get; set; } = null!;
    }
}

namespace ManagementSystem.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public IEnumerable<UserBoardEntity> UserBoards { get; set; } = [];
        public IEnumerable<UserTaskEntity> UserTasks { get; set; } = [];
    }
}

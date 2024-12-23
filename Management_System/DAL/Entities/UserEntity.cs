namespace DAL.Entities;

public class UserEntity : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public IEnumerable<UserBoardEntity> UserBoards { get; set; } = new List<UserBoardEntity>();
    public IEnumerable<UserTaskEntity> UserTasks { get; set; } = new List<UserTaskEntity>();
}
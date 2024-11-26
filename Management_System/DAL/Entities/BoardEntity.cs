namespace DAL.Entities;

public class BoardEntity : IEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public IEnumerable<TaskStatusEntity> TaskStatus { get; set; } = new List<TaskStatusEntity>();
    public IEnumerable<UserBoardEntity> UserBoards { get; set; } = new List<UserBoardEntity>();
}
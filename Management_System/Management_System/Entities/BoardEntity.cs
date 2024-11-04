namespace ManagementSystem.Entities;

public class BoardEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public IEnumerable<TableEntity> Tables { get; set; } = [];
    public IEnumerable<UserBoardEntity> UserBoards { get; set; } = [];
}
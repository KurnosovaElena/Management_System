using DAL.Enums;

namespace DAL.Entities;

public class UserBoardEntity : BaseEntity
{
    public Guid UserId { get; set; }
    public Guid BoardId { get; set; }
    public BoardRole Role { get; set; }

    public BoardEntity Board { get; set; } = null!;
}

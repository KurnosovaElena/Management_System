using DAL.Enums;

namespace DAL.Entities;

public class UserBoardEntity : Entity
{
    public Guid UserId { get; set; }
    public Guid BoardId { get; set; }
    public BoardRole Role { get; set; }

    public UserEntity User { get; set; } = null!;
    public BoardEntity Board { get; set; } = null!;
}
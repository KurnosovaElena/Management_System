using BLL.DTO.CreateDTO;

namespace BLL.DTO;

public class UserBoardDTO : CreateUserBoardDTO
{
    public Guid UserId { get; set; }
    public Guid BoardId { get; set; }
}

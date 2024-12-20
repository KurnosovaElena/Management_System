using BLL.DTO.CreateDTO;

namespace BLL.DTO;

public class BoardDto : CreateBoardDTO
{
    public Guid Id { get; set; }
}
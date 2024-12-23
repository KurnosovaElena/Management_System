using BLL.DTO.CreateDTO;

namespace BLL.DTO;

public class BoardDto : CreateBoardDto
{
    public Guid Id { get; set; }
}
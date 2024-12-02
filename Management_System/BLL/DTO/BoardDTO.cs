using BLL.DTO.CreateDTO;

namespace BLL.DTO;

public class BoardDTO : CreateBoardDTO
{
    public Guid Id { get; set; }
}
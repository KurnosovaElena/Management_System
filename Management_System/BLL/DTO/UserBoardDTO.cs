﻿using BLL.DTO.CreateDTO;

namespace BLL.DTO;

public class UserBoardDto : CreateUserBoardDto
{
    public Guid UserId { get; set; }
    public Guid BoardId { get; set; }
}

﻿using DAL.Entities;
using DAL.Enums;

namespace BLL.DTO.CreateDTO;

public class CreateTasksDto
{
    public int SerialNumber { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriority Priority { get; set; }
    public TaskEstimation TaskEstimation { get; set; }
    public Guid TableId { get; set; }

    public IEnumerable<SubtaskEntity> Subtasks { get; set; } = [];
    public IEnumerable<UserTaskEntity> UserTasks { get; set; } = [];
}

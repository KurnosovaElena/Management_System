﻿using DAL.Enums;

namespace DAL.Entities;

public class TaskEntity : BaseEntity
{
    public int SerialNumber { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriority Priority { get; set; }
    public TaskEstimation TaskEstimation { get; set; }
    public Guid TableId { get; set; }

    public IEnumerable<SubtaskEntity> Subtasks { get; set; } = new List<SubtaskEntity>();
    public IEnumerable<UserTaskEntity> UserTasks { get; set; } = new List<UserTaskEntity>();
}
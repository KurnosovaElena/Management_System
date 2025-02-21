﻿namespace DAL.Entities;

public class TaskStatusEntity : BaseEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Guid BoardId { get; set; }

    public IEnumerable<TaskEntity> Tasks { get; set; } = [];
}
﻿namespace DAL.Entities;

public class LabelEntity : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public IEnumerable<TaskEntity> Tasks { get; set; } = [];
}
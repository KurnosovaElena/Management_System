﻿namespace DAL.Entities;

public class SubtaskEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public Guid TaskId { get; set; }
}
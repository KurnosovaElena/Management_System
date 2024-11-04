using ManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Context;

public class ManagementSystemDBContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<BoardEntity> Boards { get; set; }
    public DbSet<LabelEntity> Labels { get; set; }
    public DbSet<SubtaskEntity> Subtasks { get; set; }
    public DbSet<TableEntity> Tables { get; set; }
    public DbSet<TaskEntity> Tasks { get; set; }
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<UserBoardEntity> UserBoards { get; set; }
    public DbSet<UserTaskEntity> UserTasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        DataGenerator.Init();

        modelBuilder.Entity<BoardEntity>().HasData(DataGenerator.Boards);
        modelBuilder.Entity<TableEntity>().HasData(DataGenerator.Tables);
        modelBuilder.Entity<TaskEntity>().HasData(DataGenerator.Tasks);
        modelBuilder.Entity<LabelEntity>().HasData(DataGenerator.Labels);
        modelBuilder.Entity<UserEntity>().HasData(DataGenerator.Users);
        modelBuilder.Entity<SubtaskEntity>().HasData(DataGenerator.Subtasks);
        modelBuilder.Entity<UserBoardEntity>().HasData(DataGenerator.UserBoards);
        modelBuilder.Entity<UserTaskEntity>().HasData(DataGenerator.UserTasks);
    }
}


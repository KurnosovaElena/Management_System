using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public class ManagementSystemDBContext : DbContext
{
    public ManagementSystemDBContext(DbContextOptions options) : base(options)
    {
        Database.Migrate();
    }

    public DbSet<BoardEntity> Boards { get; set; }
    public DbSet<LabelEntity> Labels { get; set; }
    public DbSet<SubtaskEntity> Subtasks { get; set; }
    public DbSet<TaskStatusEntity> TaskStatus { get; set; }
    public DbSet<TaskEntity> Tasks { get; set; }
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<UserBoardEntity> UserBoards { get; set; }
    public DbSet<UserTaskEntity> UserTasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserBoardEntity>().HasKey(ub => new {ub.BoardId , ub.UserId}); 
        modelBuilder.Entity<UserTaskEntity>().HasKey(ub => new {ub.TaskId , ub.UserId});

        DataGenerator.Init();

        modelBuilder.Entity<BoardEntity>().HasData(DataGenerator.Boards);
        modelBuilder.Entity<TaskStatusEntity>().HasData(DataGenerator.TaskStatus);
        modelBuilder.Entity<TaskEntity>().HasData(DataGenerator.Tasks);
        modelBuilder.Entity<LabelEntity>().HasData(DataGenerator.Labels);
        modelBuilder.Entity<UserEntity>().HasData(DataGenerator.Users);
        modelBuilder.Entity<SubtaskEntity>().HasData(DataGenerator.Subtasks);
        modelBuilder.Entity<UserBoardEntity>().HasData(DataGenerator.UserBoards);
        modelBuilder.Entity<UserTaskEntity>().HasData(DataGenerator.UserTasks);
    }
}
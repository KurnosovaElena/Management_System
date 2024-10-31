using ManagementSystem.Entities;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Context
{
    public class ManagementSystemDBContext : DbContext
    {
        public DbSet<Board> Boards { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Subtask> Subtasks { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<TaskEntity> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserBoard> UserBoards { get; set; }
        public DbSet<UserTask> UserTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            DataGenerator.Init();

            modelBuilder.Entity<Board>().HasData(DataGenerator.Boards);
            modelBuilder.Entity<Table>().HasData(DataGenerator.Tables);
            modelBuilder.Entity<TaskEntity>().HasData(DataGenerator.Tasks);  
            modelBuilder.Entity<Label>().HasData(DataGenerator.Labels);
            modelBuilder.Entity<User>().HasData(DataGenerator.Users);
            modelBuilder.Entity<Subtask>().HasData(DataGenerator.Subtasks);
            modelBuilder.Entity<UserBoard>().HasData(DataGenerator.UserBoards);
            modelBuilder.Entity<UserTask>().HasData(DataGenerator.UserTasks);

        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using UserMicroserviceDAL.Entities;

namespace UserMicroserviceDAL.Context;

public class UserMicriserviceDBContext : DbContext
{
    public UserMicriserviceDBContext(DbContextOptions options) : base(options)
    {
        Database.Migrate();
    }

    public DbSet<UserEntity> Users { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().HasData(
          new UserEntity
          {
              Id = Guid.NewGuid(),
              FirstName = "Alic",
              LastName = "Smith",
              Email = "alice.smith@example.com"
          },
          new UserEntity
          {
              Id = Guid.NewGuid(),
              FirstName = "Bob",
              LastName = "Johnson",
              Email = "bob.johnson@example.com"
          },
          new UserEntity
          {
              Id = Guid.NewGuid(),
              FirstName = "Ethan",
              LastName = "Jones",
              Email = "ethan.jones@example.com"
          }
      );

        base.OnModelCreating(modelBuilder);
    }
}

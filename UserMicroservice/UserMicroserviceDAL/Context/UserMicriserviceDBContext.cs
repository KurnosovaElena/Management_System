using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using UserMicroserviceDAL.Entities;

namespace UserMicroserviceDAL.Context;

public class UserMicriserviceDBContext : DbContext
{
    public UserMicriserviceDBContext(DbContextOptions options) : base(options) => 
        Database.Migrate();
    

    public DbSet<UserEntity> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var users = new List<UserEntity>
        {
            new() {
              Id = Guid.Parse("6f9a39fb-6876-4dbf-9657-f1f29b519f4d"),
              FirstName = "Alic",
              LastName = "Smith",
              Email = "alice.smith@example.com"
          },
          new() {
              Id = Guid.Parse("e3a1976b-83e4-4f65-9b8f-67a5c317f8a7"),
              FirstName = "Bob",
              LastName = "Johnson",
              Email = "bob.johnson@example.com"
          },
          new() {
              Id = Guid.Parse("0f5ea429-2e73-4a0b-93c3-f3b8b0eafb31"),
              FirstName = "Ethan",
              LastName = "Jones",
              Email = "ethan.jones@example.com"
          }
        };

        modelBuilder.Entity<UserEntity>().HasData(users);
    }
}

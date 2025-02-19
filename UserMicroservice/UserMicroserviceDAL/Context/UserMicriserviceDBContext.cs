using Microsoft.EntityFrameworkCore;
using UserMicroserviceDAL.Entities;

namespace UserMicroserviceDAL.Context;

public class UserMicriserviceDBContext : DbContext
{
    public UserMicriserviceDBContext(DbContextOptions options) : base(options)
    {
        Database.Migrate();
    }

    public DbSet<UserEntity> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserEntity>().HasData(UserData.Users);
    }
}

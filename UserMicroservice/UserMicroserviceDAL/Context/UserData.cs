using UserMicroserviceDAL.Entities;

namespace UserMicroserviceDAL.Context;

public static class UserData
{
    public static List<UserEntity> Users { get; } = new List<UserEntity>
    {
        new UserEntity
        {
            Id = Guid.Parse("6f9a39fb-6876-4dbf-9657-f1f29b519f4d"),
            FirstName = "Alice",
            LastName = "Smith",
            Email = "alice.smith@example.com"
        },
        new UserEntity
        {
            Id = Guid.Parse("e3a1976b-83e4-4f65-9b8f-67a5c317f8a7"),
            FirstName = "Bob",
            LastName = "Johnson",
            Email = "bob.johnson@example.com"
        },
        new UserEntity
        {
            Id = Guid.Parse("0f5ea429-2e73-4a0b-93c3-f3b8b0eafb31"),
            FirstName = "Ethan",
            LastName = "Jones",
            Email = "ethan.jones@example.com"
        },
        new UserEntity
        {
            Id = Guid.Parse("9f5ea420-2e73-4a0b-93c3-f3b8b0eafb35"),
            FirstName = "Ethany",
            LastName = "Jones",
            Email = "ethany.jones@example.com"
        }
    };
}

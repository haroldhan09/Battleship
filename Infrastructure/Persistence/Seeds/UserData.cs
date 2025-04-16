using Battleship.Domain.Users.Password;
using Battleship.Entities.Data;
using Microsoft.EntityFrameworkCore;

namespace Battleship.Persistence.Data.Seeding;

public static class UserData
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = new Guid("47fab74f-f962-4ede-820b-2c978502e0fa"),
                Email = "battleship-admin@bluehourgames.com",
                PasswordHash = new PasswordHash("7k2A5w22fTFpiakuDcHS4h)5xTU").ToArray(),
                Name = "Admin",
                IsAdmin = true,
                IsVerified = true
            });
    }
}
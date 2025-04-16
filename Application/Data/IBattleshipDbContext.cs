using Battleship.Entities.Data;
using Microsoft.EntityFrameworkCore;

namespace Battleship.Application.Data;

public interface IBattleshipDbContext
{
    DbSet<User> Users { get; set; }

    Task SaveChangesAsync();
}
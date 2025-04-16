using Battleship.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace Battleship.Application.Data;

public interface IBattleshipDbContext
{
    DbSet<User> Users { get; set; }

    Task SaveChangesAsync();
}
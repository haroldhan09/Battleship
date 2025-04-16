using Battleship.Application.Data;
using Battleship.Entities.Data;
using Battleship.Persistence.Data.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Battleship.Infrastructure.Data;

public class BattleshipDbContext(IConfiguration configuration) : 
    DbContext,
    IBattleshipDbContext
{
    private readonly IConfiguration _configuration = configuration;
    
    #region DbSets
    
    public DbSet<User> Users { get; set; }

    #endregion

    public Task SaveChangesAsync() => base.SaveChangesAsync();
    
    #region Builders
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        if (string.IsNullOrEmpty(connectionString))
            throw new ArgumentException("Default connection string is missing.");

        optionsBuilder.UseSqlite(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        UserData.Seed(modelBuilder);
    }
    
    #endregion
}
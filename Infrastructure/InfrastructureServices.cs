using Battleship.Application.Data;
using Battleship.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Battleship.Infrastructure;

public static class InfrastructureServices
{
    public static void AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddTransient<IBattleshipDbContext, BattleshipDbContext>();
    }
}
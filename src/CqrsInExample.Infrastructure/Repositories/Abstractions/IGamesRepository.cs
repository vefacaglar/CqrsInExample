using CqrsInExample.Domain.Games;

namespace CqrsInExample.Infrastructure.Repositories.Abstractions
{
    public interface IGamesRepository
    {
        Task<List<GameItem>> GetGamesAsync();
    }
}

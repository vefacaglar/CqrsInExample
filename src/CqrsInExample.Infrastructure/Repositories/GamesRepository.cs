using CqrsInExample.Domain.Games;
using CqrsInExample.Infrastructure.Repositories.Abstractions;
using Dapper;
using System.Data;

namespace CqrsInExample.Infrastructure.Repositories
{
    public class GamesRepository : IGamesRepository
    {
        private readonly IDbConnection _connection;

        public GamesRepository(
            IMsSqlDbConnectionFactory connectionFactory
            )
        {
            _connection = connectionFactory.CreateConnection();
        }

        public async Task<List<GameItem>> GetGamesAsync()
        {
            var result = await _connection.QueryAsync<GameItem>("select Id, Name, Description from Games with(nolock)");
            return result.ToList();
        }
    }
}

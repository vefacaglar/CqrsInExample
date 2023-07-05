using CqrsInExample.Infrastructure.GamesContext.Abstractions;
using CqrsInExample.Infrastructure.Repositories.Abstractions;

namespace CqrsInExample.Infrastructure.Repositories
{
    public class GamesRepository : IGamesRepository
    {
        private readonly IDbContext _dbContext;

        public GamesRepository(
            IDbContext dbContext
            )
        {
            _dbContext = dbContext;
        }

        
    }
}

using CqrsInExample.Infrastructure.GamesContext;
using CqrsInExample.Infrastructure.Repositories;
using CqrsInExample.Infrastructure.Repositories.Abstractions;

namespace CqrsInExample.Infrastructure
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;
        Task SaveChangesAsync();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly GamesDbContext _dbContext;

        public UnitOfWork(
            GamesDbContext context
            )
        {
            _dbContext = context;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new EfRepository<T>(_dbContext);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}

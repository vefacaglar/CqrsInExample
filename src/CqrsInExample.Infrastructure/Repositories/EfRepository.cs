using CqrsInExample.Infrastructure.GamesContext;
using CqrsInExample.Infrastructure.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace CqrsInExample.Infrastructure.Repositories
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly GamesDbContext _context;
        private readonly DbSet<T> _dbSet;

        public EfRepository(
            GamesDbContext context
        )
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
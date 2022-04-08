using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BlazorTemplate.Data.Repositories
{
    public class Repository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;

        public Repository(DbContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context), "The context cannot be null.");
            }

            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }
        
        public ValueTask<TEntity?> GetAsync(int id)
        {
            return _context.Set<TEntity>().FindAsync(id);
        }
        public TEntity? Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            return _context.Set<TEntity>().ToListAsync();
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

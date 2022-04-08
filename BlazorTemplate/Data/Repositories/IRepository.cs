using System.Linq.Expressions;

namespace BlazorTemplate.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        ValueTask<TEntity?> GetAsync(int id);
        TEntity? Get(int id);
        Task<List<TEntity>> GetAllAsync();
        List<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}

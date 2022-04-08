using BlazorTemplate.Data.Repositories;

namespace BlazorTemplate.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ITaskRepository Tasks { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Tasks = new TaskRepository(_context);
        }
        
        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

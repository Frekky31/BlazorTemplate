using BlazorTemplate.Data.Repositories;

namespace BlazorTemplate.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ITaskRepository Tasks { get; }
        Task<int> SaveAsync();
    }
}

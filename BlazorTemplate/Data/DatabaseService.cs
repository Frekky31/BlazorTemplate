using BlazorTemplate.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorTemplate.Data
{
    public class DatabaseService
    {
        private readonly ApplicationDbContext _appDBContext;

        public DatabaseService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        
        public async Task<List<ToDoTask>> GetAllTasksAsync()
        {
            return await _appDBContext.Tasks.ToListAsync();
        }

        public async Task<List<Topic>> GetAllTopicsAsync()
        {
            return await _appDBContext.Topics.ToListAsync();
        }

        public async Task<bool> InsertTaskAsync(ToDoTask task)
        {
            await _appDBContext.Tasks.AddAsync(task);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        
        public async Task<ToDoTask?> GetTaskAsync(int Id)
        {
            return await _appDBContext.Tasks.FirstOrDefaultAsync(c => c.Id.Equals(Id));
        }

        public async Task<bool> UpdateTaskAsync(ToDoTask task)
        {
            _appDBContext.Tasks.Update(task);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteTaskAsync(ToDoTask task)
        {
            _appDBContext.Remove(task);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}
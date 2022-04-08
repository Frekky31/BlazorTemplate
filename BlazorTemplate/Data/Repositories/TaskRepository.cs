using BlazorTemplate.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorTemplate.Data.Repositories
{
    public class TaskRepository : Repository<ToDoTask>, ITaskRepository
    {
        public TaskRepository(DbContext context) : base(context)
        {
        }

        public Task<List<ToDoTask>> GetTasksToDoAsync()
        {
            return ApplicationDbContext.Tasks.Where(x => x.IsDone == false).ToListAsync();
        }

        public List<ToDoTask> GetTasksToDo()
        {
            return ApplicationDbContext.Tasks.Where(x => x.IsDone == false).ToList();
        }

        public List<ToDoTask> GetTasksTitleStartsWith(string search)
        {
            return ApplicationDbContext.Tasks.Where(x => x.Title.StartsWith(search)).ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return _context as ApplicationDbContext; }
        }
    }
}

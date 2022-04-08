using BlazorTemplate.Data.Models;

namespace BlazorTemplate.Data.Repositories
{
    public interface ITaskRepository : IRepository<ToDoTask>
    {
        Task<List<ToDoTask>> GetTasksToDoAsync();
        List<ToDoTask> GetTasksToDo();
    }
}

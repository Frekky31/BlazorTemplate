using BlazorTemplate.Data.Models;

namespace BlazorTemplate.Data.Repositories
{
    public interface ITopicRepository : IRepository<Topic>
    {
        Task<List<Topic>> GetTopicAsync();
        List<Topic> GetTopic();
    }
}

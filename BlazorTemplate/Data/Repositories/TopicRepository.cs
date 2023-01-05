using BlazorTemplate.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorTemplate.Data.Repositories
{
    public class TopicRepository : Repository<Topic>, ITopicRepository
    {
        public TopicRepository(DbContext context) : base(context)
        {
        }

        public Task<List<Topic>> GetTopicAsync()
        {
            return ApplicationDbContext.Topics.ToListAsync();
        }

        public List<Topic> GetTopic()
        {
            return ApplicationDbContext.Topics.ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return _context as ApplicationDbContext; }
        }
    }
}

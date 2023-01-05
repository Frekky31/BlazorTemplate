using BlazorTemplate.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorTemplate.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ToDoTask> Tasks { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}

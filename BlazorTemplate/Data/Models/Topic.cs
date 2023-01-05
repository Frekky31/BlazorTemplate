using System.ComponentModel.DataAnnotations;

namespace BlazorTemplate.Data.Models
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<ToDoTask> Tasks { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BlazorTemplate.Data.Models
{
    public class ToDoTask
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsDone { get; set; }
    }
}

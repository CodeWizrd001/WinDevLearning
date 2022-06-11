using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool IsDone { get; set; }
    }
    
}
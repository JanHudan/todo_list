using System.ComponentModel.DataAnnotations;

namespace ToDoListAPI.Model
{
    public class ToDoTask
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        public bool Reminder { get; set; }
        public Priority Priority { get; set; }
        public Type Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime Completed { get; set; }
    }

    public enum Priority
    {
        Low, Medium, High
    }

    public enum Type
    {
        School, Work, Workout, Friends, SelImprovement
    }
}

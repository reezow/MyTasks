using System.ComponentModel.DataAnnotations;

namespace MyTasksWeb.Data
{
    public class Task
    {
        public int Id { get; set; }

        [Display (Name = "What To Do?")]
        public string? Title { get; set; }

        [Display(Name = "Am I done?")]
        public bool isCompleted { get; set; }
    }
}

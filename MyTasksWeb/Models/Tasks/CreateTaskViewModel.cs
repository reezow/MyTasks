using System.ComponentModel.DataAnnotations;

namespace MyTasksWeb.Models.Tasks
{
    public class CreateTaskViewModel
    {
        [Display(Name = "What To Do?")]
        public string? Title { get; set; }

        [Display(Name = "Am I done?")]
        public bool isCompleted { get; set; }
    }
}

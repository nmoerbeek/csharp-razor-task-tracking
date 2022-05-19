using System.ComponentModel.DataAnnotations;

namespace Tasker
{
    public class Task
    {
       
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [MinLength(10)]
        [Required ]
        public string Description { get; set; }
        [Range(1,5)]
        [Required]
        public int Priority { get; set; }
    }
}

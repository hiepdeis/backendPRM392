using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backendPRM.Models
{
    public class TaskProject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        [Required]
        [MaxLength(50)]
        public string Status { get; set; } = "To Do";
        public DateTime? DueDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Quan hệ
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;

        public int CreatedBy { get; set; }
        public User Creator { get; set; } = null!;

        public ICollection<TaskAssignee> TaskAssignees { get; set; } = new List<TaskAssignee>();
    }
}

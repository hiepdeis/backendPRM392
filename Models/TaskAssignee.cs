using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backendPRM.Models
{
    public class TaskAssignee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Quan hệ
        public int TaskId { get; set; }
        public TaskProject TaskProjects { get; set; } = null!;

        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}

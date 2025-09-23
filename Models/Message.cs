using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backendPRM.Models
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        // Quan hệ
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;

        public int SenderId { get; set; }
        public User Sender { get; set; } = null!;
    }
}

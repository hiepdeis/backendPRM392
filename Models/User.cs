using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backendPRM.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Fullname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string? Avatar { get; set; }

        // OTP cho forgot password
        public string? OtpCode { get; set; }
        public DateTime? OtpExpiresAt { get; set; }
        public bool OtpUsed { get; set; } = false;

        // Quan hệ
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;

        public ICollection<Project> CreatedProjects { get; set; } = new List<Project>();
        public ICollection<ProjectMember> ProjectMembers { get; set; } = new List<ProjectMember>();
        public ICollection<TaskProject> CreatedTasks { get; set; } = new List<TaskProject>();
        public ICollection<TaskAssignee> AssignedTasks { get; set; } = new List<TaskAssignee>();
        public ICollection<Message> Messages { get; set; } = new List<Message>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
    }
}

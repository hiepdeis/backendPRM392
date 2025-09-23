using backendPRM.Models;
using Microsoft.EntityFrameworkCore;

namespace backendPRM
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectMember> ProjectMembers { get; set; }
        public DbSet<TaskProject> TaskProjects { get; set; }
        public DbSet<TaskAssignee> TaskAssignees { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Unique cho Email User
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            // Unique cho ProjectMember (ProjectId, UserId)
            modelBuilder.Entity<ProjectMember>()
                .HasIndex(pm => new { pm.ProjectId, pm.UserId })
                .IsUnique();

            // Unique cho TaskAssignee (TaskId, UserId)
            modelBuilder.Entity<TaskAssignee>()
                .HasIndex(ta => new { ta.TaskId, ta.UserId })
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }

    }
}

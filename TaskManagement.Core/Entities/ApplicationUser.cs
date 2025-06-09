using Microsoft.AspNetCore.Identity;

namespace TaskManagement.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Avatar { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public string FullName => $"{FirstName} {LastName}".Trim();

        // Navigation properties
        //public virtual Organization? Organization { get; set; }
        //public virtual ICollection<Project> CreatedProjects { get; set; } = new List<Project>();
        //public virtual ICollection<ProjectMember> ProjectMemberships { get; set; } = new List<ProjectMember>();
        //public virtual ICollection<TaskEntity> AssignedTasks { get; set; } = new List<TaskEntity>();
    }
}

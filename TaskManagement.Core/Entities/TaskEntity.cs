using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Enums;

namespace TaskManagement.Core.Entities
{
    public class TaskEntity : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Priority Priority { get; set; } = Priority.Medium;
        public DateTime? DueDate { get; set; }
        public string? AssignedToId { get; set; }
        public int ProjectId { get; set; }
        public int TaskStatusId { get; set; }

        // Navigation properties
        public virtual ApplicationUser? AssignedTo { get; set; }
        public virtual Project Project { get; set; } = null!;
        public virtual TaskStatus TaskStatus { get; set; } = null!;
        public virtual ICollection<TaskComment> Comments { get; set; } = new List<TaskComment>();
        public virtual ICollection<TaskAttachment> Attachments { get; set; } = new List<TaskAttachment>();
        public virtual ICollection<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();

    }
}

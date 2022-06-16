using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker_FullStack.Models
{
    public class Bug
    {
        [Key]
        public int BugId { get; set; }

        [Required]
        public string BugName { get; set; }

        [Required]
        public string Type { get; set; } = "Bug";

        public string Description { get; set; }

        [Required]
        public string Status { get; set; } = "Unassigned";

        [Required]
        public string Priority { get; set; }

        [Required]
        public int ReporterId { get; set; } = 0;

        public int AssigneeId { get; set; }
    }
}

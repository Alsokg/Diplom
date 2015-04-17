using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMonitoringSystem.Models
{
    public class MarkPoint
    {
        [HiddenInput (DisplayName = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display (Name = "Task name")]
        [Required]
        public String Name { get; set; }
        [HiddenInput (DisplayName = false)]
        public int? SubjectId { get; set; }
        [Display (Name = "Maximum marks value")]
        [Range(0,100)]
        [Required]
        public double maxValue { get; set; }
        [Display (Name = "Deadline")]
        [Required]
        public Date Date { get; set; }
        public virtual Subject Subject { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }

    }
}

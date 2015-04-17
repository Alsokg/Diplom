using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMonitoringSystem.Models
{
    public class MarkPoint
    {
        [HiddenInput (DisplayName = false)]
        public int Id { get; set; }
        [Display (Name = "Task name")]
        public String Name { get; set; }
        [HiddenInput (DisplayName = false)]
        public int? SubjectId { get; set; }
        [Display (Name = "Maximum marks value")]
        public double maxValue { get; set; }
        [Display (Name = "Deadline")]
        public Date Date { get; set; }
        public virtual Subject Subject { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMonitoringSystem.Models
{
    public class MarkPoint
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int? SubjectId { get; set; }
        public double maxValue { get; set; }
        public DateTime Date { get; set; }
        public virtual Subject Subject { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }

    }
}
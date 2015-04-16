using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMonitoringSystem.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public int? MarkPointId { get; set; }
        public int? StudentId { get; set; }
        public virtual Student Student { get; set; }
        public virtual MarkPoint MarkPoint { get; set; }

    }
}
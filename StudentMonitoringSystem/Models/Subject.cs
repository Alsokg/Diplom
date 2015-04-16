using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMonitoringSystem.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<MarkPoint> Points { get; set; }
        public virtual ICollection<Lector> Lectors { get; set; }

    }
}
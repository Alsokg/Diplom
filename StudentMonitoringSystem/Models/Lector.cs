using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMonitoringSystem.Models
{
    public class Lector
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String SurName { get; set; }
        public String Grade { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }

    }
}
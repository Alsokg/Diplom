using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMonitoringSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String SurName { get; set; }
        public String StudentBookNumber { get; set; }
        public int? GroupId { get; set; }
        public virtual Group Group { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }

    }
}
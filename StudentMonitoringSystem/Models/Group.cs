using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMonitoringSystem.Models
{
    public class Group
    {
        
        public int Id { get; set; }
        public String Name { get; set; }
        public int? FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Student> Students { get; set; }

    }
}
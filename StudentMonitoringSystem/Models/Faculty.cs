using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMonitoringSystem.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int? UniversityId { get; set; }
        public virtual University University { get; set; }
        public virtual ICollection<Group> Groups { get; set; }

    }
}
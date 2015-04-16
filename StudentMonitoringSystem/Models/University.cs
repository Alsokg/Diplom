using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMonitoringSystem.Models
{
    public class University
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public virtual ICollection<Faculty> Faculties { get; set; }
    }
}
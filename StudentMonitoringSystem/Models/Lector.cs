using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMonitoringSystem.Models
{
    public class Lector
    {
        [HiddenInput (DisplayName = false)]
        public int Id { get; set; }
        [Display (Name = "FirstName")]
        public String Name { get; set; }
        [Display (Name = "LastName")]
        public String SurName { get; set; }
        [Display (Name = "Degree")]
        public String Grade { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }

    }
}

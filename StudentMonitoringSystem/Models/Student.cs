using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentMonitoringSystem.Models
{
    public class Student
    {
        [HiddenInput (DisplayValue = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display (Name = "FirstName")]
        public String Name { get; set; }
        [Display (Name = "SecondName")]
        public String SurName { get; set; }
        [Display (Name = "StudentBookID")]
        public String StudentBookNumber { get; set; }
        [HiddenInput (DisplayValue = false)]
        public int? GroupId { get; set; }
        public virtual Group Group { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }

    }
}

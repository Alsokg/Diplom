using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMonitoringSystem.Models
{
    public class Lector
    {
        [HiddenInput (DisplayValue = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display (Name = "FirstName")]
        [Required]
        public String Name { get; set; }
        [Display (Name = "LastName")]
        [Required]
        public String SurName { get; set; }
        [Display (Name = "Degree")]
        public String Grade { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }

    }
}

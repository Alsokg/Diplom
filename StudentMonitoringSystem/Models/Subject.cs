using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentMonitoringSystem.Models
{
    public class Subject
    {
        [HiddenInput (DisplayValue = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display (Name = "Course name") ]
        [Required]
        public String Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<MarkPoint> Points { get; set; }
        public virtual ICollection<Lector> Lectors { get; set; }

    }
}

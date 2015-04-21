using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentMonitoringSystem.Models
{
    public class MarkPoint
    {
        [HiddenInput (DisplayValue= false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display (Name = "Task name")]
        [Required]
        public String Name { get; set; }
        [HiddenInput (DisplayValue = false)]
        public int? SubjectId { get; set; }
        [Display (Name = "Maximum marks value")]
        [Range(0,100)]
        [Required]
        public double maxValue { get; set; }
        /*
        [Display (Name = "Deadline")]
        [Required]
        public DateTime Date { get; set; }*/
        public virtual Subject Subject { get; set; }

        public  ICollection<Mark> Marks { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMonitoringSystem.Models
{
    public class University
    {
        [HiddenInput (DisplayValue = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Display (Name = "University name")]
        [Required]
        public String Name { get; set; }
        [Display (Name = "Address")]
        public String Address { get; set; }
        public virtual ICollection<Faculty> Faculties { get; set; }
    }
}

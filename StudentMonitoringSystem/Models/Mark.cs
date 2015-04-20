using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentMonitoringSystem.Models
{
    public class Mark
    {
        [HiddenInput (DisplayValue = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display (Name = "Decemical Value")]
        [Required]
        public double Value { get; set; }
        [HiddenInput (DisplayValue = false)]
        public int? MarkPointId { get; set; }
        [HiddenInput (DisplayValue = false)]
        public int? StudentId { get; set; }
        public virtual Student Student { get; set; }
        public virtual MarkPoint MarkPoint { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentMonitoringSystem.Models
{
    public class Faculty
    {
        [HiddenInput (DisplayValue = false)]
        public int Id { get; set; }
        [Display (Name = "Full faculty name")]
        public String Name { get; set; }
        [HiddenInput (DisplayValue = false)]
        public int? UniversityId { get; set; }
        public virtual University University { get; set; }
        public virtual ICollection<Group> Groups { get; set; }

    }
}

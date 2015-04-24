﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using StudentMonitoringSystem.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace StudentMonitoringSystem.Controllers
{

    public class StudentMarkController : Controller
    {
        private UniversityContext db = new UniversityContext();

        // GET: StudentMark
        [Authorize(Roles = "Student, Lector")]
        public ActionResult Index()
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            var current = manager.FindById(User.Identity.GetUserId());
            {
                bool flag = false;

                var s = new Student();
                foreach (Student ss in db.Student)
                {
                    if (current == null) {
                        return View("Current");
                    }
                    if (ss.StudentBookNumber == current.StydentBookNumber)
                    {
                        flag = true;
                        s = ss;
                    }
                }
                if (flag != false)
                {
                    String fullName = s.Name + "   " + s.SurName;
                    ViewData["StudentFullName"] = fullName;
                    ViewData["Student"] = s;
                    ViewData["Subjects"] = s.Subjects;

                    var Marks = s.Marks;
                    ViewData["Marks"] = Marks;
                }

                return View();

            }

        }
    }
}

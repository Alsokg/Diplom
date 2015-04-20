using System;
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
        [Authorize(Roles = "Student")]
        public ActionResult Index()
        {


            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            var current = manager.FindById(User.Identity.GetUserId());

            bool flag = false;
            int? IdfromDB = null;
            var s = new Student();
            foreach(Student ss in db.Student){
                if (ss.StudentBookNumber == current.StydentBookNumber)
                {
                    flag = true;
                    IdfromDB = s.Id;
                    s = ss;
                   
                }
            }
            if (IdfromDB != null)
            {
                String  fullName= s.Name + "   " + s.SurName;
                ViewData["StudentFullName"] = fullName;
                var subjectsList = s.Subjects.ToList();
                ViewData["Subjects"] = s.Subjects;
                ViewData["Marks"] = s.Marks;
                
            }
            
            return View();
        }
    }
}
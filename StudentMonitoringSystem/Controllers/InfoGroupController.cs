using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentMonitoringSystem.Models;

namespace StudentMonitoringSystem.Controllers
{
    [Authorize(Roles="Lector")]
    public class InfoGroupController : Controller
    {
        private UniversityContext db = new UniversityContext();

        // GET: InfoGroup
        public ActionResult Index()
        {
            var group = db.Group.Include(g => g.Faculty).Include(s => s.Students);
            Lector l = db.Lector.Find(4);
            var Marks = db.Mark.ToList();
            ViewBag.subjects = l.Subjects.ToList();
            return View(group.ToList());
        }

        // GET: InfoGroup/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group group = db.Group.Find(id);
            if (group == null)
            {
                return HttpNotFound();
            }
            ViewData["Students"] =  db.Student;
            ViewData["Marks"] =  db.MarkPoint;
            ViewData["Subjects"] =  db.Subject;
            return View(group);
        }

        // GET: InfoGroup/Create
        public ActionResult Create()
        {
            ViewBag.FacultyId = new SelectList(db.Faculty, "Id", "Name");
            return View();
        }

        // POST: InfoGroup/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,FacultyId")] Group group)
        {
            if (ModelState.IsValid)
            {
                db.Group.Add(group);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.FacultyId = new SelectList(db.Faculty, "Id", "Name", group.FacultyId);
            return View(group);
        }

        // GET: InfoGroup/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group group = await db.Group.FindAsync(id);
            if (group == null)
            {
                return HttpNotFound();
            }
            ViewBag.FacultyId = new SelectList(db.Faculty, "Id", "Name", group.FacultyId);
            return View(group);
        }

        // POST: InfoGroup/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,FacultyId")] Group group)
        {
            if (ModelState.IsValid)
            {
                db.Entry(group).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.FacultyId = new SelectList(db.Faculty, "Id", "Name", group.FacultyId);
            return View(group);
        }

        // GET: InfoGroup/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group group = await db.Group.FindAsync(id);
            if (group == null)
            {
                return HttpNotFound();
            }
            return View(group);
        }

        // POST: InfoGroup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Group group = await db.Group.FindAsync(id);
            db.Group.Remove(group);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

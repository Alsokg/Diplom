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
    public class MarksController : Controller
    {
        private UniversityContext db = new UniversityContext();

        // GET: Marks
        public async Task<ActionResult> Index()
        {
            var mark = db.Mark.Include(m => m.MarkPoint).Include(m => m.Student);
            return View(await mark.ToListAsync());
        }

        // GET: Marks/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mark mark = await db.Mark.FindAsync(id);
            if (mark == null)
            {
                return HttpNotFound();
            }
            return View(mark);
        }

        // GET: Marks/Create
        public ActionResult Create()
        {
            ViewBag.MarkPointId = new SelectList(db.MarkPoint, "Id", "Name");
            ViewBag.StudentId = new SelectList(db.Student, "Id", "Name");
            return View();
        }

        // POST: Marks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Value,MarkPointId,StudentId")] Mark mark)
        {
            if (ModelState.IsValid)
            {
                db.Mark.Add(mark);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.MarkPointId = new SelectList(db.MarkPoint, "Id", "Name", mark.MarkPointId);
            ViewBag.StudentId = new SelectList(db.Student, "Id", "Name", mark.StudentId);
            return View(mark);
        }

        // GET: Marks/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mark mark = await db.Mark.FindAsync(id);
            if (mark == null)
            {
                return HttpNotFound();
            }
            ViewBag.MarkPointId = new SelectList(db.MarkPoint, "Id", "Name", mark.MarkPointId);
            ViewBag.StudentId = new SelectList(db.Student, "Id", "Name", mark.StudentId);
            return View(mark);
        }

        // POST: Marks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Value,MarkPointId,StudentId")] Mark mark)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mark).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.MarkPointId = new SelectList(db.MarkPoint, "Id", "Name", mark.MarkPointId);
            ViewBag.StudentId = new SelectList(db.Student, "Id", "Name", mark.StudentId);
            return View(mark);
        }

        // GET: Marks/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mark mark = await db.Mark.FindAsync(id);
            if (mark == null)
            {
                return HttpNotFound();
            }
            return View(mark);
        }

        // POST: Marks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Mark mark = await db.Mark.FindAsync(id);
            db.Mark.Remove(mark);
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

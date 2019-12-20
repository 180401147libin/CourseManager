using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseManager.Models;
using System.Net;

namespace CourseManager.Controllers
{
    public class ClassController : Controller
    {
        private CourseManagerEntities db = new CourseManagerEntities();

        //
        // GET: /Class/

        public ActionResult Index()
        {
            return View(db.Classes.ToList());
        }

        //
        // GET: /Class/Details/5

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Classes classes = db.Classes.Find(id);
            return View(classes);
        }

        //
        // GET: /Class/Create

        public ActionResult Create()
        {
            var teachers =db.Teachers.ToList();
            ViewBag.Teachers = teachers;
            return View();
        }

        //
        // POST: /Class/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,TeacherId")] Classes classes)
        {
            if (ModelState.IsValid)
            {
                db.Classes.Add(classes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(classes);
        }

        //
        // GET: /Class/Edit/5

        public ActionResult Edit(int? id )
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var teachers = db.Teachers.ToList();
            ViewBag.Teachers = teachers;
            Classes classes = db.Classes.Find(id);
            if (classes == null)
            {
                return HttpNotFound();
            }
            return View(classes);
        }

        //
        // POST: /Class/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Classes classes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classes);
        }

        //
        // GET: /Class/Delete/5

        public ActionResult Delete(int id = 0)
        {
            var teachers = db.Teachers.ToList();
            ViewBag.Teachers = teachers;
            Classes classes = db.Classes.Find(id);
            if (classes == null)
            {
                return HttpNotFound();
            }
            return View(classes);
        }

        //
        // POST: /Class/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Classes classes = db.Classes.Find(id);
            db.Classes.Remove(classes);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ShowCourseManagement(int id)
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
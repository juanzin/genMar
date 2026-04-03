using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fotografiaMVC.Models;

namespace fotografiaMVC.Controllers
{
    public class AboutController : Controller
    {
        private photographyEntities db = new photographyEntities();

        // GET: About
        public ActionResult Index()
        {
            // var photographers = db.Photographers.Include(p => p.TypeUsers);
            // var photographers = db.Photographers.ToList();
            var photographer = db.Photographers.Where(p => p.Id == 1).ToList();

            var model = new About
            {
                Description = photographer[0].Biography,
                Instagram = photographer[0].Instagram,
                Facebook = photographer[0].Facebook
            };

            return View(model);
        }

        // GET: About/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Photographers photographers = db.Photographers.Find(id);
            if (photographers == null)
            {
                return HttpNotFound();
            }
            return View(photographers);
        }

        // GET: About/Create
        public ActionResult Create()
        {
            ViewBag.Type_User = new SelectList(db.TypeUsers, "Id", "Type");
            return View();
        }

        // POST: About/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Materno,Paterno,Username,UrlFoto,Password,Instagram,Facebook,Email,Biography,Type_User")] Photographers photographers)
        {
            if (ModelState.IsValid)
            {
                db.Photographers.Add(photographers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Type_User = new SelectList(db.TypeUsers, "Id", "Type", photographers.Type_User);
            return View(photographers);
        }

        // GET: About/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Photographers photographers = db.Photographers.Find(id);
            if (photographers == null)
            {
                return HttpNotFound();
            }
            ViewBag.Type_User = new SelectList(db.TypeUsers, "Id", "Type", photographers.Type_User);
            return View(photographers);
        }

        // POST: About/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Materno,Paterno,Username,UrlFoto,Password,Instagram,Facebook,Email,Biography,Type_User")] Photographers photographers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(photographers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Type_User = new SelectList(db.TypeUsers, "Id", "Type", photographers.Type_User);
            return View(photographers);
        }

        // GET: About/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Photographers photographers = db.Photographers.Find(id);
            if (photographers == null)
            {
                return HttpNotFound();
            }
            return View(photographers);
        }

        // POST: About/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Photographers photographers = db.Photographers.Find(id);
            db.Photographers.Remove(photographers);
            db.SaveChanges();
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

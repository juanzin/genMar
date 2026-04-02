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
    public class PhotographersController : Controller
    {
        private photographyEntities db = new photographyEntities();

        // GET: Photographers
        public ActionResult Index()
        {
            var photographers = db.Photographers.Include(p => p.TypeUsers);
            return View(photographers.ToList());
        }

        // GET: Photographers/Details/5
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

        // GET: Photographers/Create
        public ActionResult Create()
        {
            ViewBag.Type_User = new SelectList(db.TypeUsers, "Id", "Type");
            return View();
        }

        // POST: Photographers/Create
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

        // GET: Photographers/Edit/5
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

        // POST: Photographers/Edit/5
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

        // GET: Photographers/Delete/5
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

        // POST: Photographers/Delete/5
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

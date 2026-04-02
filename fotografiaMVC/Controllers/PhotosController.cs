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
    public class PhotosController : Controller
    {
        private photographyEntities db = new photographyEntities();

        // GET: Photos
        public ActionResult Index()
        {
            var photos = db.Photos.Include(p => p.Categories).Include(p => p.Photographers);
            return View(photos.ToList());
        }

        // GET: Photos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Photos photos = db.Photos.Find(id);
            if (photos == null)
            {
                return HttpNotFound();
            }
            return View(photos);
        }

        // GET: Photos/Create
        public ActionResult Create()
        {
            ViewBag.Category_Id = new SelectList(db.Categories, "Id", "Name");
            ViewBag.Photographer_Id = new SelectList(db.Photographers, "Id", "Name");
            return View();
        }

        // POST: Photos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Description,Created_date,Photographer_Id,Url_Photo,Category_Id")] Photos photos)
        {
            if (ModelState.IsValid)
            {
                db.Photos.Add(photos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Category_Id = new SelectList(db.Categories, "Id", "Name", photos.Category_Id);
            ViewBag.Photographer_Id = new SelectList(db.Photographers, "Id", "Name", photos.Photographer_Id);
            return View(photos);
        }

        // GET: Photos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Photos photos = db.Photos.Find(id);
            if (photos == null)
            {
                return HttpNotFound();
            }
            ViewBag.Category_Id = new SelectList(db.Categories, "Id", "Name", photos.Category_Id);
            ViewBag.Photographer_Id = new SelectList(db.Photographers, "Id", "Name", photos.Photographer_Id);
            return View(photos);
        }

        // POST: Photos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Description,Created_date,Photographer_Id,Url_Photo,Category_Id")] Photos photos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(photos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Category_Id = new SelectList(db.Categories, "Id", "Name", photos.Category_Id);
            ViewBag.Photographer_Id = new SelectList(db.Photographers, "Id", "Name", photos.Photographer_Id);
            return View(photos);
        }

        // GET: Photos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Photos photos = db.Photos.Find(id);
            if (photos == null)
            {
                return HttpNotFound();
            }
            return View(photos);
        }

        // POST: Photos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Photos photos = db.Photos.Find(id);
            db.Photos.Remove(photos);
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

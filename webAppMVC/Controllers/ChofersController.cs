using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using webAppMVC.Models;

namespace webAppMVC.Controllers
{
    public class ChofersController : Controller
    {
        private companyEntities db = new companyEntities();

        // GET: Chofers
        public ActionResult Index()
        {
            return View(db.Chofers.ToList());
        }

        // GET: Chofers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chofer chofer = db.Chofers.Find(id);
            if (chofer == null)
            {
                return HttpNotFound();
            }
            return View(chofer);
        }

        // GET: Chofers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chofers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,ApellidoPaterno,ApellidoMaterno,Licencia,Telefono,Disponibilidad")] Chofer chofer)
        {
            if (ModelState.IsValid)
            {
                db.Chofers.Add(chofer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chofer);
        }

        // GET: Chofers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chofer chofer = db.Chofers.Find(id);
            if (chofer == null)
            {
                return HttpNotFound();
            }
            return View(chofer);
        }

        // POST: Chofers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,ApellidoPaterno,ApellidoMaterno,Licencia,Telefono,Disponibilidad")] Chofer chofer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chofer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chofer);
        }

        // GET: Chofers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chofer chofer = db.Chofers.Find(id);
            if (chofer == null)
            {
                return HttpNotFound();
            }
            return View(chofer);
        }

        // POST: Chofers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Chofer chofer = db.Chofers.Find(id);
            db.Chofers.Remove(chofer);
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

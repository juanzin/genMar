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
    public class CamionsController : Controller
    {
        private companyEntities db = new companyEntities();

        // GET: Camions
        public ActionResult Index()
        {
            return View(db.Camions.ToList());
        }

        // GET: Camions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Camion camion = db.Camions.Find(id);
            if (camion == null)
            {
                return HttpNotFound();
            }
            return View(camion);
        }

        // GET: Camions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Camions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tipo,Matricula,Modelo,Marca,Disponibilidad,Kilometraje,UrlFoto")] Camion camion)
        {
            if (ModelState.IsValid)
            {
                db.Camions.Add(camion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(camion);
        }

        // GET: Camions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Camion camion = db.Camions.Find(id);
            if (camion == null)
            {
                return HttpNotFound();
            }
            return View(camion);
        }

        // POST: Camions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tipo,Matricula,Modelo,Marca,Disponibilidad,Kilometraje,UrlFoto")] Camion camion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(camion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(camion);
        }

        // GET: Camions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Camion camion = db.Camions.Find(id);
            if (camion == null)
            {
                return HttpNotFound();
            }
            return View(camion);
        }

        // POST: Camions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Camion camion = db.Camions.Find(id);
            db.Camions.Remove(camion);
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

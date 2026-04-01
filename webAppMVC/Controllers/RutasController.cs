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
    public class RutasController : Controller
    {
        private companyEntities db = new companyEntities();

        // GET: Rutas
        public ActionResult Index()
        {
            var rutas = db.Rutas.Include(r => r.Camion).Include(r => r.Chofer);
            return View(rutas.ToList());
        }

        // GET: Rutas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ruta ruta = db.Rutas.Find(id);
            if (ruta == null)
            {
                return HttpNotFound();
            }
            return View(ruta);
        }

        // GET: Rutas/Create
        public ActionResult Create()
        {
            ViewBag.IdCamion = new SelectList(db.Camions, "Id", "Matricula");
            ViewBag.IdChofer = new SelectList(db.Chofers, "Id", "Nombre");
            return View();
        }

        // POST: Rutas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Origen,Destino,FechaSalida,FechaLlegada,FechaRegistro,ATiempo,Distancia,IdCamion,IdChofer")] Ruta ruta)
        {
            if (ModelState.IsValid)
            {
                db.Rutas.Add(ruta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCamion = new SelectList(db.Camions, "Id", "Matricula", ruta.IdCamion);
            ViewBag.IdChofer = new SelectList(db.Chofers, "Id", "Nombre", ruta.IdChofer);
            return View(ruta);
        }

        // GET: Rutas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ruta ruta = db.Rutas.Find(id);
            if (ruta == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCamion = new SelectList(db.Camions, "Id", "Matricula", ruta.IdCamion);
            ViewBag.IdChofer = new SelectList(db.Chofers, "Id", "Nombre", ruta.IdChofer);
            return View(ruta);
        }

        // POST: Rutas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Origen,Destino,FechaSalida,FechaLlegada,FechaRegistro,ATiempo,Distancia,IdCamion,IdChofer")] Ruta ruta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ruta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCamion = new SelectList(db.Camions, "Id", "Matricula", ruta.IdCamion);
            ViewBag.IdChofer = new SelectList(db.Chofers, "Id", "Nombre", ruta.IdChofer);
            return View(ruta);
        }

        // GET: Rutas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ruta ruta = db.Rutas.Find(id);
            if (ruta == null)
            {
                return HttpNotFound();
            }
            return View(ruta);
        }

        // POST: Rutas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ruta ruta = db.Rutas.Find(id);
            db.Rutas.Remove(ruta);
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

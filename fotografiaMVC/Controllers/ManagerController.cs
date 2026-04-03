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
    public class ManagerController : Controller
    {
        private photographyEntities db = new photographyEntities();
        private int ID_USER = 1;
        // GET: Manager
        public ActionResult Index()
        {
            // var photographers = db.Photographers.Include(p => p.TypeUsers);
            var photographer = db.Photographers.FirstOrDefault(p => p.Id == ID_USER);
            var model = new PhotographerInfo
            {
                Username = "",
                Instagram = "",
                Facebook = "",
                Description = "description",
                Phone = "",
                Email = "email",
                Location = "location",

            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(PhotographerInfo model)
        {

            string username = model.Username;
            string instagram = model.Instagram;
            string facebook = model.Facebook;
            string email = model.Email;
            string phone = model.Phone;
            string location = model.Location;
            string description = model.Description;

            //var user = new Photographers
            //{
            //    Name = originalPhotographerInfo.Name,
            //    Materno = originalPhotographerInfo.Materno,
            //    Paterno = originalPhotographerInfo.Paterno,
            //    Username = username,
            //    UrlFoto = originalPhotographerInfo.UrlFoto,
            //    Password = originalPhotographerInfo.Password,
            //    Instagram = instagram,
            //    Facebook = facebook,
            //    Biography = description,
            //    Email = email,
            //    Type_User = 1
            //};
            var photographer = db.Photographers.FirstOrDefault(p => p.Id == ID_USER);
            photographer.Username = username;
            photographer.Instagram = instagram;
            photographer.Facebook = facebook;
            photographer.Biography = description;
            photographer.Email = email;

            // db.Photographers.Add(user);
            db.SaveChanges();

            return RedirectToAction("Index");
        }



        // GET: Manager/Details/5
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

        // GET: Manager/Create
        public ActionResult Create()
        {
            ViewBag.Type_User = new SelectList(db.TypeUsers, "Id", "Type");
            return View();
        }

        // POST: Manager/Create
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

        // GET: Manager/Edit/5
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

        // POST: Manager/Edit/5
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

        // GET: Manager/Delete/5
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

        // POST: Manager/Delete/5
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

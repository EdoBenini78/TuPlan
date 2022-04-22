using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TuPlan.Models;

namespace TuPlan.Controllers
{
    public class InmueblesController : Controller
    {
        private DbTuPlanContext db = new DbTuPlanContext();

        // GET: Inmuebles
        public ActionResult Index()
        {
            return View(db.DbInmuebles.ToList());
        }

        // GET: Inmuebles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inmueble inmueble = db.DbInmuebles.Find(id);
            if (inmueble == null)
            {
                return HttpNotFound();
            }
            return View(inmueble);
        }

        // GET: Inmuebles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inmuebles/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Direccion,Descripcion,Precio,Tipo,Destacado,Mascota,Amueblado,Dormitorios,Garantia,Propietario,Telefono,MailPropietario,Esquina")] Inmueble inmueble)
        {
            if (ModelState.IsValid)
            {
                db.DbInmuebles.Add(inmueble);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(inmueble);
        }

        // GET: Inmuebles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inmueble inmueble = db.DbInmuebles.Find(id);
            if (inmueble == null)
            {
                return HttpNotFound();
            }
            return View(inmueble);
        }

        // POST: Inmuebles/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Direccion,Descripcion,Precio,Tipo,Destacado,Mascota,Amueblado,Dormitorios,Garantia,Propietario,Telefono,MailPropietario,Esquina")] Inmueble inmueble)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inmueble).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inmueble);
        }

        // GET: Inmuebles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inmueble inmueble = db.DbInmuebles.Find(id);
            if (inmueble == null)
            {
                return HttpNotFound();
            }
            return View(inmueble);
        }

        // POST: Inmuebles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inmueble inmueble = db.DbInmuebles.Find(id);
            db.DbInmuebles.Remove(inmueble);
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

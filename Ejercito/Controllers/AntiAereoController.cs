using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ejercito.DAL;
using Ejercito.Models.Unidades;

namespace Ejercito.Controllers
{
    public class AntiAereoController : Controller
    {
        private EjercitoContext db = new EjercitoContext();

        // GET: AntiAereo
        public ActionResult Index()
        {
            return View(db.AntiAereos.ToList());
        }

        // GET: AntiAereo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AntiAereo antiAereo = db.AntiAereos.Find(id);
            if (antiAereo == null)
            {
                return HttpNotFound();
            }
            return View(antiAereo);
        }

        // GET: AntiAereo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AntiAereo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Precio,Movimiento,PotenciaFuego,Valor")] AntiAereo antiAereo)
        {
            if (ModelState.IsValid)
            {
                db.AntiAereos.Add(antiAereo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(antiAereo);
        }

        // GET: AntiAereo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AntiAereo antiAereo = db.AntiAereos.Find(id);
            if (antiAereo == null)
            {
                return HttpNotFound();
            }
            return View(antiAereo);
        }

        // POST: AntiAereo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Precio,Movimiento,PotenciaFuego,Valor")] AntiAereo antiAereo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(antiAereo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(antiAereo);
        }

        // GET: AntiAereo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AntiAereo antiAereo = db.AntiAereos.Find(id);
            if (antiAereo == null)
            {
                return HttpNotFound();
            }
            return View(antiAereo);
        }

        // POST: AntiAereo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AntiAereo antiAereo = db.AntiAereos.Find(id);
            db.AntiAereos.Remove(antiAereo);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ejercito.DAL;
using Ejercito.Models;

namespace Ejercito.Controllers
{
    public class CapituloEjercitoController : Controller
    {
        private EjercitoContext db = new EjercitoContext();

        // GET: CapituloEjercito
        public ActionResult Index()
        {
            return View(db.Ejercitos.ToList());
        }

        // GET: CapituloEjercito/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CapituloEjercito capituloEjercito = db.Ejercitos.Find(id);
            if (capituloEjercito == null)
            {
                return HttpNotFound();
            }
            return View(capituloEjercito);
        }

        // GET: CapituloEjercito/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CapituloEjercito/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre")] CapituloEjercito capituloEjercito)
        {
            if (ModelState.IsValid)
            {
                db.Ejercitos.Add(capituloEjercito);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(capituloEjercito);
        }

        // GET: CapituloEjercito/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CapituloEjercito capituloEjercito = db.Ejercitos.Find(id);
            if (capituloEjercito == null)
            {
                return HttpNotFound();
            }
            return View(capituloEjercito);
        }

        // POST: CapituloEjercito/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre")] CapituloEjercito capituloEjercito)
        {
            if (ModelState.IsValid)
            {
                db.Entry(capituloEjercito).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(capituloEjercito);
        }

        // GET: CapituloEjercito/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CapituloEjercito capituloEjercito = db.Ejercitos.Find(id);
            if (capituloEjercito == null)
            {
                return HttpNotFound();
            }
            return View(capituloEjercito);
        }

        // POST: CapituloEjercito/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CapituloEjercito capituloEjercito = db.Ejercitos.Find(id);
            db.Ejercitos.Remove(capituloEjercito);
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

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
    public class AmetralladorController : Controller
    {
        private EjercitoContext db = new EjercitoContext();

        // GET: Ametrallador
        public ActionResult Index()
        {
            return View(db.Ametralladors.ToList());
        }

        // GET: Ametrallador/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ametrallador ametrallador = db.Ametralladors.Find(id);
            if (ametrallador == null)
            {
                return HttpNotFound();
            }
            return View(ametrallador);
        }

        // GET: Ametrallador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ametrallador/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Precio,Valor,PotenciaFuego,Movimiento")] Ametrallador ametrallador)
        {
            if (ModelState.IsValid)
            {
                db.Ametralladors.Add(ametrallador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ametrallador);
        }

        // GET: Ametrallador/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ametrallador ametrallador = db.Ametralladors.Find(id);
            if (ametrallador == null)
            {
                return HttpNotFound();
            }
            return View(ametrallador);
        }

        // POST: Ametrallador/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Precio,Valor,PotenciaFuego,Movimiento")] Ametrallador ametrallador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ametrallador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ametrallador);
        }

        // GET: Ametrallador/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ametrallador ametrallador = db.Ametralladors.Find(id);
            if (ametrallador == null)
            {
                return HttpNotFound();
            }
            return View(ametrallador);
        }

        // POST: Ametrallador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ametrallador ametrallador = db.Ametralladors.Find(id);
            db.Ametralladors.Remove(ametrallador);
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

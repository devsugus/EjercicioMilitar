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
    public class CanonController : Controller
    {
        private EjercitoContext db = new EjercitoContext();

        // GET: Canon
        public ActionResult Index()
        {
            return View(db.Canones.ToList());
        }

        // GET: Canon/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Canon canon = db.Canones.Find(id);
            if (canon == null)
            {
                return HttpNotFound();
            }
            return View(canon);
        }

        // GET: Canon/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Canon/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,PotenciaFuego,Precio,Valor")] Canon canon)
        {
            if (ModelState.IsValid)
            {
                db.Canones.Add(canon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(canon);
        }

        // GET: Canon/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Canon canon = db.Canones.Find(id);
            if (canon == null)
            {
                return HttpNotFound();
            }
            return View(canon);
        }

        // POST: Canon/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,PotenciaFuego,Precio,Valor")] Canon canon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(canon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(canon);
        }

        // GET: Canon/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Canon canon = db.Canones.Find(id);
            if (canon == null)
            {
                return HttpNotFound();
            }
            return View(canon);
        }

        // POST: Canon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Canon canon = db.Canones.Find(id);
            db.Canones.Remove(canon);
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

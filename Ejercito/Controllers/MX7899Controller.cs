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
    public class MX7899Controller : Controller
    {
        private EjercitoContext db = new EjercitoContext();

        // GET: MX7899
        public ActionResult Index()
        {
            return View(db.MX7899.ToList());
        }

        // GET: MX7899/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MX7899 mX7899 = db.MX7899.Find(id);
            if (mX7899 == null)
            {
                return HttpNotFound();
            }
            return View(mX7899);
        }

        // GET: MX7899/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MX7899/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Precio,Valor,Movimiento")] MX7899 mX7899)
        {
            if (ModelState.IsValid)
            {
                db.MX7899.Add(mX7899);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mX7899);
        }

        // GET: MX7899/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MX7899 mX7899 = db.MX7899.Find(id);
            if (mX7899 == null)
            {
                return HttpNotFound();
            }
            return View(mX7899);
        }

        // POST: MX7899/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Precio,Valor,Movimiento")] MX7899 mX7899)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mX7899).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mX7899);
        }

        // GET: MX7899/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MX7899 mX7899 = db.MX7899.Find(id);
            if (mX7899 == null)
            {
                return HttpNotFound();
            }
            return View(mX7899);
        }

        // POST: MX7899/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MX7899 mX7899 = db.MX7899.Find(id);
            db.MX7899.Remove(mX7899);
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

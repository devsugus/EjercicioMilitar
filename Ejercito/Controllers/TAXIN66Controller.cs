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
    public class TAXIN66Controller : Controller
    {
        private EjercitoContext db = new EjercitoContext();

        // GET: TAXIN66
        public ActionResult Index()
        {
            return View(db.TAXIN66.ToList());
        }

        // GET: TAXIN66/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAXIN66 tAXIN66 = db.TAXIN66.Find(id);
            if (tAXIN66 == null)
            {
                return HttpNotFound();
            }
            return View(tAXIN66);
        }

        // GET: TAXIN66/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TAXIN66/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Precio,Valor,Movimiento")] TAXIN66 tAXIN66)
        {
            if (ModelState.IsValid)
            {
                db.TAXIN66.Add(tAXIN66);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tAXIN66);
        }

        // GET: TAXIN66/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAXIN66 tAXIN66 = db.TAXIN66.Find(id);
            if (tAXIN66 == null)
            {
                return HttpNotFound();
            }
            return View(tAXIN66);
        }

        // POST: TAXIN66/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Precio,Valor,Movimiento")] TAXIN66 tAXIN66)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tAXIN66).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tAXIN66);
        }

        // GET: TAXIN66/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAXIN66 tAXIN66 = db.TAXIN66.Find(id);
            if (tAXIN66 == null)
            {
                return HttpNotFound();
            }
            return View(tAXIN66);
        }

        // POST: TAXIN66/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TAXIN66 tAXIN66 = db.TAXIN66.Find(id);
            db.TAXIN66.Remove(tAXIN66);
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

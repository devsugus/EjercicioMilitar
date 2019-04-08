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
    public class TorpederoMController : Controller
    {
        private EjercitoContext db = new EjercitoContext();

        // GET: TorpederoM
        public ActionResult Index()
        {
            return View(db.TorpederoM.ToList());
        }

        // GET: TorpederoM/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TorpederoM torpederoM = db.TorpederoM.Find(id);
            if (torpederoM == null)
            {
                return HttpNotFound();
            }
            return View(torpederoM);
        }

        // GET: TorpederoM/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TorpederoM/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Precio,Movimiento,PotenciaFuego,Blindaje,Valor")] TorpederoM torpederoM)
        {
            if (ModelState.IsValid)
            {
                db.TorpederoM.Add(torpederoM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(torpederoM);
        }

        // GET: TorpederoM/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TorpederoM torpederoM = db.TorpederoM.Find(id);
            if (torpederoM == null)
            {
                return HttpNotFound();
            }
            return View(torpederoM);
        }

        // POST: TorpederoM/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Precio,Movimiento,PotenciaFuego,Blindaje,Valor")] TorpederoM torpederoM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(torpederoM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(torpederoM);
        }

        // GET: TorpederoM/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TorpederoM torpederoM = db.TorpederoM.Find(id);
            if (torpederoM == null)
            {
                return HttpNotFound();
            }
            return View(torpederoM);
        }

        // POST: TorpederoM/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TorpederoM torpederoM = db.TorpederoM.Find(id);
            db.TorpederoM.Remove(torpederoM);
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

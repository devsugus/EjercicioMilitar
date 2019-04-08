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
    public class InfanteriaBasicaController : Controller
    {
        private EjercitoContext db = new EjercitoContext();

        // GET: InfanteriaBasica
        public ActionResult Index()
        {
            return View(db.InfanteriaBasicas.ToList());
        }

        // GET: InfanteriaBasica/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InfanteriaBasica infanteriaBasica = db.InfanteriaBasicas.Find(id);
            if (infanteriaBasica == null)
            {
                return HttpNotFound();
            }
            return View(infanteriaBasica);
        }

        // GET: InfanteriaBasica/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InfanteriaBasica/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Precio,Valor,PotenciaFuego,Movimiento")] InfanteriaBasica infanteriaBasica)
        {
            if (ModelState.IsValid)
            {
                db.InfanteriaBasicas.Add(infanteriaBasica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(infanteriaBasica);
        }

        // GET: InfanteriaBasica/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InfanteriaBasica infanteriaBasica = db.InfanteriaBasicas.Find(id);
            if (infanteriaBasica == null)
            {
                return HttpNotFound();
            }
            return View(infanteriaBasica);
        }

        // POST: InfanteriaBasica/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Precio,Valor,PotenciaFuego,Movimiento")] InfanteriaBasica infanteriaBasica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(infanteriaBasica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(infanteriaBasica);
        }

        // GET: InfanteriaBasica/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InfanteriaBasica infanteriaBasica = db.InfanteriaBasicas.Find(id);
            if (infanteriaBasica == null)
            {
                return HttpNotFound();
            }
            return View(infanteriaBasica);
        }

        // POST: InfanteriaBasica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InfanteriaBasica infanteriaBasica = db.InfanteriaBasicas.Find(id);
            db.InfanteriaBasicas.Remove(infanteriaBasica);
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

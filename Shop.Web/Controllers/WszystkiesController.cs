using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Shop.Web.Models;

namespace Shop.Web.Controllers
{
    public class WszystkiesController : Controller
    {
        private WszystkieDBtxt db = new WszystkieDBtxt();

        // GET: Wszystkies
        public ActionResult Index()
        {
            // Sortowanie
            // var sortowanie = from s in db.Ksiazki select s;
            // sortowanie = sortowanie.OrderBy(s => s.Nazwa);
            // Wyswietlenie posortowanej listy
            // return View(sortowanie.ToList());
            return View(db.Ksiazki.OrderBy(s => s.Nazwa).ToList());
        }



        public PartialViewResult Wszystkie()
        {
            List<Wszystkie> model = db.Ksiazki.OrderBy(s=>s.Nazwa).ToList();
            return PartialView("_Ksiazki",model);
        }
        public PartialViewResult Audiobooki()
        {
            List<Wszystkie> model = db.Ksiazki.SqlQuery("SELECT * FROM Wszystkies WHERE Rodzaj='0'").OrderBy(s => s.Nazwa).ToList();
            return PartialView("_Ksiazki", model);
        }
        public PartialViewResult Ebooki()
        {
            List<Wszystkie> model = db.Ksiazki.SqlQuery("SELECT * FROM Wszystkies WHERE Rodzaj='1'").OrderBy(s => s.Nazwa).ToList();
            return PartialView("_Ksiazki", model);
        }



        // GET: Wszystkies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wszystkie wszystkie = db.Ksiazki.Find(id);
            if (wszystkie == null)
            {
                return HttpNotFound();
            }
            return View(wszystkie);
        }

        // GET: Wszystkies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wszystkies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nazwa,Data_wydania,Cena,Autor,Wydawnictwo,Rodzaj")] Wszystkie wszystkie)
        {
            if (ModelState.IsValid)
            {
                db.Ksiazki.Add(wszystkie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wszystkie);
        }

        // GET: Wszystkies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wszystkie wszystkie = db.Ksiazki.Find(id);
            if (wszystkie == null)
            {
                return HttpNotFound();
            }
            return View(wszystkie);
        }

        // POST: Wszystkies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nazwa,Data_wydania,Cena,Autor,Wydawnictwo,Rodzaj")] Wszystkie wszystkie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wszystkie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wszystkie);
        }

        // GET: Wszystkies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wszystkie wszystkie = db.Ksiazki.Find(id);
            if (wszystkie == null)
            {
                return HttpNotFound();
            }
            return View(wszystkie);
        }

        // POST: Wszystkies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Wszystkie wszystkie = db.Ksiazki.Find(id);
            db.Ksiazki.Remove(wszystkie);
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

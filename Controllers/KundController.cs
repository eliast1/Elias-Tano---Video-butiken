using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uppgift6Avancerat.Context;
using Uppgift6Avancerat.Models;

namespace Uppgift6Avancerat.Controllers
{
    public class KundController : Controller
    {
        KundContext db = new KundContext();
        // GET: Kund
        public ActionResult Index()
        {
            var kunder = db.Kund.ToList();  
            return View(kunder);
        }

        public ActionResult OrderByName()
        {
            var kundSort = from p in db.Kund
                orderby p.Namn ascending
                select p;
            return View(kundSort);
        }
        // GET: Kund/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Kund/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kund/Create
        [HttpPost]
        public ActionResult Create(Kunder kund)
        {
            try
            {
                db.Kund.Add(kund);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(kund);
            }
        }

        // GET: Kund/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Kund/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Kund/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Kund/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

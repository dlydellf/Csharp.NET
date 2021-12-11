using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Lines 54-82 calculate insuree's quote:
                insuree.Quote = 50; // Step 1(a)

                // determining Insuree's age:
                int date = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                int dob = int.Parse(insuree.DateOfBirth.ToString("yyyyMMdd"));
                int age = (date - dob) / 10000;

                // Step 1(b): 18 or younger? +$100 to Quote,
                // Step 1(c): 19 to 25? +$50 to Quote, or...
                // Step 1(d): 25 or older? +$25 to Quote:
                insuree.Quote += (age <= 18) ? 100 : ((age >= 19 && age <= 25) ? 50 : 25);

                // Steps 1(e & f): Is car older than 2000 or newer than 2015? +$25 to Quote:
                insuree.Quote += (insuree.CarYear < 2000 || insuree.CarYear > 2015) ? 25 : 0;

                // Step 1(g): Is this a Porsche? +$25 to Quote, and...
                // Step 1(h): Is this Porsche a 911 Carrera? +$25 to Quote:
                insuree.Quote += (insuree.CarMake == "Porsche") ? ((insuree.CarModel == "911 Carrera") ? 50 : 25) : 0;

                // Step 1(i): +$10 to Quote for EACH Speeding Ticket:
                insuree.Quote += (insuree.SpeedingTickets * 10);

                // Step 1(j): for DUIs, increase quote by 25%:
                decimal dui = .25M;
                insuree.Quote += insuree.DUI ? (insuree.Quote * dui) : 0;

                // Step 1(k): for full coverage, increase quote by 50%:
                decimal fullCoverage = .5M;
                insuree.Quote += insuree.CoverageType ? (insuree.Quote * fullCoverage) : 0;

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

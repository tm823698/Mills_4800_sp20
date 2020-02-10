using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mills_4800.DAL;
using Mills_4800.Models;

namespace Mills_4800.Controllers
{
    public class FlightDetailsController : Controller
    {
        private MIS4200Mills db = new MIS4200Mills();

        // GET: FlightDetails
        public ActionResult Index()
        {
            return View(db.FlightDetails.ToList());
        }

        // GET: FlightDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FlightDetail flightDetail = db.FlightDetails.Find(id);
            if (flightDetail == null)
            {
                return HttpNotFound();
            }
            return View(flightDetail);
        }

        // GET: FlightDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FlightDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "flightDetailID,price,numberOfTickets")] FlightDetail flightDetail)
        {
            if (ModelState.IsValid)
            {
                db.FlightDetails.Add(flightDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(flightDetail);
        }

        // GET: FlightDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FlightDetail flightDetail = db.FlightDetails.Find(id);
            if (flightDetail == null)
            {
                return HttpNotFound();
            }
            return View(flightDetail);
        }

        // POST: FlightDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "flightDetailID,price,numberOfTickets")] FlightDetail flightDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(flightDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(flightDetail);
        }

        // GET: FlightDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FlightDetail flightDetail = db.FlightDetails.Find(id);
            if (flightDetail == null)
            {
                return HttpNotFound();
            }
            return View(flightDetail);
        }

        // POST: FlightDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FlightDetail flightDetail = db.FlightDetails.Find(id);
            db.FlightDetails.Remove(flightDetail);
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

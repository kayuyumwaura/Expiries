using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Expiries.Models;

namespace Expiries.Controllers
{
    public class WardsController : Controller
    {
        // GET: Wards/index
        public ActionResult Index()
        {
            using (DBModel db = new DBModel())
            {
                return View(db.tb_wards.ToList());
            }
                
        }

        // GET: Wards/Details/5
        public ActionResult Details(int id)
        {
            using (DBModel db = new DBModel())
            {
                return View(db.tb_wards.Where(x => x.ward_id == id).FirstOrDefault()); 
            }
        }

        // GET: Wards/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wards/Create
        [HttpPost]
        public ActionResult Create(tb_wards wards)
        {
            try
            {
                // TODO: Add insert logic here
                using (DBModel db = new DBModel())
                {
                    db.tb_wards.Add(wards);
                    db.SaveChanges();
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Wards/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBModel db = new DBModel())
            {
                return View(db.tb_wards.Where(x => x.ward_id == id).FirstOrDefault());
            }
        }

        // POST: Wards/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, tb_wards wards)
        {
            try
            {
                using (DBModel db = new DBModel())
                {
                    db.Entry(wards).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                    // TODO: Add update logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Wards/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBModel db = new DBModel())
            {
                return View(db.tb_wards.Where(x => x.ward_id == id).FirstOrDefault());
            }
        }

        // POST: Wards/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, tb_wards wards)
        {
            try
            {
                // TODO: Add delete logic here
                using (DBModel db = new DBModel())
                {
                    wards = db.tb_wards.Where(x => x.ward_id == id).FirstOrDefault();
                    db.tb_wards.Remove(wards);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_APTA_CMS_DEMO.Models;
namespace MVC_APTA_CMS_DEMO.Controllers
{
    public class AttendeeController : Controller
    {
        //
        // GET: /Attende/

        public ActionResult Index()
        {
            List<member> memberlist = new List<member>();
            using (LAPTASModels db = new LAPTASModels())
            {
                memberlist = db.members.ToList<member>();
            }
            return View(memberlist);
        }

        //
        // GET: /Attende/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Attende/Create

        public ActionResult Create()
        {
            return View(new member());
        }

        //
        // POST: /Attende/Create

        [HttpPost]
        public ActionResult Create(member membernmodel)
        {
            try
            {
                using (LAPTASModels db = new LAPTASModels())
                {
                    db.members.Add(membernmodel);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

        //
        // GET: /Attende/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Attende/Edit/5

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

        //
        // GET: /Attende/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Attende/Delete/5

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

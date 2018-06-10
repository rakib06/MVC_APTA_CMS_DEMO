using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_APTA_CMS_DEMO.Models;

namespace MVC_APTA_CMS_DEMO.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            List<apta_admin> adminlist = new List<apta_admin>();

            using (ModelsCMS db = new ModelsCMS())
            {
                adminlist = db.apta_admins.ToList<apta_admin>();
            }
             
            
            return View(adminlist);
        }

        //
        // GET: /Admin/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Admin/Create

        public ActionResult Create()
        {
            return View(new apta_admin());
        }

        //
        // POST: /Admin/Create

        [HttpPost]
        public ActionResult Create(apta_admin adminmodel)
        {
            try
            {
                using (ModelsCMS db = new ModelsCMS())
                {
                    db.apta_admins.Add(adminmodel);
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
        // GET: /Admin/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Admin/Edit/5

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
        // GET: /Admin/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Admin/Delete/5

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

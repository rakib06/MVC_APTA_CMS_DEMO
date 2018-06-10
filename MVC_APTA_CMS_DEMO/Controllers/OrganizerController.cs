using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_APTA_CMS_DEMO.Models;
namespace MVC_APTA_CMS_DEMO.Controllers
{
    public class OrganizerController : Controller
    {
        //
        // GET: /Organizer/

        public ActionResult Index()
        {
            List<organizer> organizerlist = new List<organizer>();
            using (CMSAPTADBModels db = new CMSAPTADBModels())
            {
                organizerlist = db.organizers.ToList<organizer>();
            }
            return View(organizerlist);
        }

        //
        // GET: /Organizer/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Organizer/Create

        public ActionResult Create()
        {
            return View(new organizer());
        }

        //
        // POST: /Organizer/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Organizer/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Organizer/Edit/5

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
        // GET: /Organizer/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Organizer/Delete/5

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

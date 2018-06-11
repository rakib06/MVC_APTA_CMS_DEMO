using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_APTA_CMS_DEMO.Models;
namespace MVC_APTA_CMS_DEMO.Controllers
{
    public class ConferenceController : Controller
    {
        //
        // GET: /Conference/

        public ActionResult Index()
        {
            List<conference_event> conference_eventlist = new List<conference_event>();
            using (ModelsCMS db = new ModelsCMS())
            {
                conference_eventlist = db.conference_events.ToList<conference_event>();
            }
            return View(conference_eventlist);
        }
        public ActionResult IndexPublic()
        {
            List<conference_event> conference_eventlist = new List<conference_event>();
            using (ModelsCMS db = new ModelsCMS())
            {
                conference_eventlist = db.conference_events.ToList<conference_event>();
            }
            return View(conference_eventlist);
        }

        //
        // GET: /Conference/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Conference/Create

        public ActionResult Create()
        {
            return View(new conference_event());
        }

        //
        // POST: /Conference/Create

        [HttpPost]
        public ActionResult Create(conference_event conferenceModel)
        {

            try
            {
                using (ModelsCMS db = new ModelsCMS())
                {
                    db.conference_events.Add(conferenceModel);
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
        // GET: /Conference/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Conference/Edit/5

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
        // GET: /Conference/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Conference/Delete/5

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

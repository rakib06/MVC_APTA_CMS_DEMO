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
            using (ModelsCMS db = new ModelsCMS())
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
        public ActionResult Create(organizer organizerModel)
        {



            try
            {
                using (ModelsCMS db = new ModelsCMS())
                {
                    db.organizers.Add(organizerModel);
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

        public ActionResult AddOrEdit(int id=0)
        {
            organizer organizerModel = new organizer();
            using (ModelsCMS db = new ModelsCMS())
            {
               if (id != 0)
                   organizerModel = db.organizers.Where(x => x.OrganizerId == id).FirstOrDefault();
               organizerModel.ConferenceCollection = db.conference_events.ToList<conference_event>();

            }

         /*   // hardcore 
            organizerModel.ConferenceCollection = new List<conference_event>()
            {
                new conference_event() {conferenceID = 1, Name = "Computer"},

                new conference_event() {conferenceID = 1, Name = "Computer"},
            };
            */
        
            return View(organizerModel);
        }

        [HttpPost]
        public ActionResult AddOrEdit(organizer org)
        {




            try
            {
                using (ModelsCMS db = new ModelsCMS())
                {
                    db.organizers.Add(org);
                    db.SaveChanges();
                }

                return RedirectToAction("wait","Home");
            }
            catch
            {
                return View("Error");
            }
            
        }
        public ActionResult Error()
        {
            return PartialView("Error");
        }
       

    }
}

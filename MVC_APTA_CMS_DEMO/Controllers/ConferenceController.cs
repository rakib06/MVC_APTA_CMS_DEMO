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
        public ActionResult IndexOrg()
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
            conference_event conferenceModel = new conference_event();
            using (ModelsCMS db = new ModelsCMS())
            {
                conferenceModel = db.conference_events.Where(x => x.conferenceID == id).FirstOrDefault();
            }
            return View(conferenceModel);
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

           
                using (ModelsCMS db = new ModelsCMS())
                {
                    db.conference_events.Add(conferenceModel);
                    db.SaveChanges();
                }
                
                return RedirectToAction("Index");
            
            
        }

        //
        // GET: /Conference/Edit/5

        public ActionResult Edit(int id)
        {
            conference_event ConferenceModel = new conference_event();
            using (ModelsCMS db = new ModelsCMS())
            {
                ConferenceModel = db.conference_events.Where(x => x.conferenceID == id).FirstOrDefault();
            }
            return View(ConferenceModel);
        }

        //
        // POST: /Attende/Edit/5

        [HttpPost]
        public ActionResult Edit(conference_event ConferenceModel)
        {
            using (ModelsCMS db = new ModelsCMS())
            {
                db.Entry(ConferenceModel).State = System.Data.EntityState.Modified;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        //
        // GET: /Conference/Delete/5

        public ActionResult Delete(int id)
        {
            conference_event ConferenceModel = new conference_event();
            using (ModelsCMS db = new ModelsCMS())
            {
                ConferenceModel = db.conference_events.Where(x => x.conferenceID == id).FirstOrDefault();
            }
            return View(ConferenceModel);
        }

        //
        // POST: /Conference/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            using (ModelsCMS db = new ModelsCMS())
            {
                conference_event confModel = db.conference_events.Where(x => x.conferenceID == id).FirstOrDefault();
                db.conference_events.Remove(confModel);
                db.SaveChanges();

            }

            return RedirectToAction("Index");
        }
    }
}

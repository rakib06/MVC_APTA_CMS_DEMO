using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_APTA_CMS_DEMO.Models;
namespace MVC_APTA_CMS_DEMO.Controllers
{
    public class TeamsPaperController : Controller
    {
        //
        // GET: /TeamsPaper/

        public ActionResult Index()
        {
            List<teams_paper> teams_paperlist = new List<teams_paper>();
            using (ModelsCMS db = new ModelsCMS())
            {
                teams_paperlist = db.teams_papers.ToList<teams_paper>();
            }
            return View(teams_paperlist);
        }
        public ActionResult IndexPublic()
        {
            List<teams_paper> teams_paperlist = new List<teams_paper>();
            using (ModelsCMS db = new ModelsCMS())
            {
                teams_paperlist = db.teams_papers.ToList<teams_paper>();
            }
            return View(teams_paperlist);
        }
        public ActionResult IndexOrg()
        {
            List<teams_paper> teams_paperlist = new List<teams_paper>();
            using (ModelsCMS db = new ModelsCMS())
            {
                teams_paperlist = db.teams_papers.ToList<teams_paper>();
            }
            return View(teams_paperlist);
        }
        //
        // GET: /TeamsPaper/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /TeamsPaper/Create

        public ActionResult Create(int id=0)
        {
            teams_paper teamModel = new teams_paper();
            using (ModelsCMS db = new ModelsCMS())
            {
                if (id != 0)
                    teamModel= db.teams_papers.Where(x => x.DelegatesID == id).FirstOrDefault();
                teamModel.ConferenceCollection = db.conference_events.ToList<conference_event>();

            }

           

            return View(teamModel);
        }
        // POST: /TeamsPaper/Create
        [HttpPost]
        public ActionResult Create(teams_paper org)
        {




            try
            {
                using (ModelsCMS db = new ModelsCMS())
                {
                    db.teams_papers.Add(org);
                    db.SaveChanges();
                }

                return RedirectToAction("Create", "Attendee");
            }
            catch
            {
                return View("Required");
            }

        }
        //
       

       

        //
        // GET: /TeamsPaper/Edit/5

        public ActionResult Edit(int id)
        {
            teams_paper teamModel = new teams_paper();
            using (ModelsCMS db = new ModelsCMS())
            {
                teamModel = db.teams_papers.Where(x => x.DelegatesID == id).FirstOrDefault();
            }
            return View(teamModel);
        }

        //
        // POST: /Attende/Edit/5

        [HttpPost]
        public ActionResult Edit(member teamModel)
        {
            using (ModelsCMS db = new ModelsCMS())
            {
                db.Entry(teamModel).State = System.Data.EntityState.Modified;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        //
        // GET: /TeamsPaper/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /TeamsPaper/Delete/5

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

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
            using (CMSAPTADBModels db = new CMSAPTADBModels())
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

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TeamsPaper/Create

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
        // GET: /TeamsPaper/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /TeamsPaper/Edit/5

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

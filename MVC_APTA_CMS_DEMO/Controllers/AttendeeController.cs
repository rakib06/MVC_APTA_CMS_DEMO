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
            using (ModelsCMS db = new ModelsCMS())
            {
                memberlist = db.members.ToList<member>();
            }
            return View(memberlist);
        }
        public ActionResult IndexPublic()
        {
            List<member> memberlist = new List<member>();
            using (ModelsCMS db = new ModelsCMS())
            {
                memberlist = db.members.ToList<member>();
            }
            return View(memberlist);
        }
        public ActionResult IndexOrg()
        {
            List<member> memberlist = new List<member>();
            using (ModelsCMS db = new ModelsCMS())
            {
                memberlist = db.members.ToList<member>();
            }
            return View(memberlist);
        }
        //
        // GET: /Attende/Details/5

        public ActionResult Details(int id)
        {
            member memberModel =new member();
            using (ModelsCMS db = new ModelsCMS())
            {
                memberModel = db.members.Where(x => x.AttendeeID == id).FirstOrDefault();
            }
            return View(memberModel);
        }

        //
        // GET: /Attende/Create

        public ActionResult Create(int id=0)
        {
            member memberModel = new member();
            using (ModelsCMS db = new ModelsCMS())
            {
                if (id != 0)
                   memberModel= db.members.Where(x => x.AttendeeID == id).FirstOrDefault();
                memberModel.TeamCollection = db.teams_papers.ToList<teams_paper>();

            }



            return View(memberModel);
        }
         [HttpPost]
        public ActionResult Create(member org)
        {


              

            try
            {
                using (ModelsCMS db = new ModelsCMS())
                {
                    db.members.Add(org);
                    db.SaveChanges();
                }

                return RedirectToAction("Create", "Attendee");
            }
            catch
            {
                return View("Error");
            }

        }

        //
        // POST: /Attende/Create

        

        //
        // GET: /Attende/Edit/5

        public ActionResult Edit(int id)
        {
        member memberModel = new member();
            using (ModelsCMS db = new ModelsCMS())
            {
                memberModel = db.members.Where(x => x.AttendeeID == id).FirstOrDefault();
            }
            return View(memberModel);
        }

        //
        // POST: /Attende/Edit/5

        [HttpPost]
        public ActionResult Edit(member memberModel)
        {
            using (ModelsCMS db = new ModelsCMS())
            {
                db.Entry(memberModel).State = System.Data.EntityState.Modified;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
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

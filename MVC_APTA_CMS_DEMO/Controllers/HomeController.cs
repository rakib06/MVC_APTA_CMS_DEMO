using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_APTA_CMS_DEMO.Models;
namespace MVC_APTA_CMS_DEMO.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
           
            return View();
        }
        //partial view
        public ActionResult testNav()
        {
            return PartialView("testnav");
        }
        public ActionResult orgtNav()
        {
            return PartialView("orgNav");
        }
        public ActionResult adminNav()
        {
            return PartialView("adminNav");
        }
        
        public ActionResult Welcome()
        {
            return PartialView("welcome");
        }
        public ActionResult Error()
        {
            return PartialView("Error");
        }

       
        public ActionResult orgRegister()
        {
            
            return View();

        }
        [HttpPost]
        public ActionResult orgRegister(organizer org)
        {

            ModelsCMS db = new ModelsCMS();
            db.organizers.Add(org);
            db.SaveChanges();
            ViewBag.message = "You are Successfully Register";
            return View("Wait");

        }
       
        public ActionResult orgLogin()
        {

            return View();
        }
        [HttpPost]
        public ActionResult orgLogin(organizer org)
        {
            ModelsCMS db = new ModelsCMS();
            var userLoggedIn = db.organizers.SingleOrDefault(x => x.Email == org.Email && x.Password == org.Password && x.approve==1);
            if (userLoggedIn != null)
            {
                ViewBag.message = "loggedin";
               ViewBag.triedOne = "yes";
                return RedirectToAction("orgHome","Home",new{Email=org.Email,name=org.Name});
            }
            else
            {
                ViewBag.triedOnce = "yes";
                return View ("Error");
            }
            
        }

        public ActionResult orgHome(string Email,string Name)
        {
            ViewBag.Email = Email;
            ViewBag.Name = Name;
            return View();
        }

    }
}

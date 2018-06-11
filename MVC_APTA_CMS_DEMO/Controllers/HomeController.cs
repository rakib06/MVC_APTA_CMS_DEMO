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
           
            return View("Index");
        }
        public ActionResult adminLogin()
        {

            return View("adminLogin");
        }
        //partial view
        public ActionResult testNav()
        {
            return PartialView("testnav");
        }
        public ActionResult orgcont()
        {
            return PartialView("orgcont");
        }
        public ActionResult adcont()
        {
            return PartialView("adcont");
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
        public ActionResult wait()
        {
            return PartialView("wait");
        }
        public ActionResult Error()
        {
            return PartialView("Error");
        }
        public ActionResult contact_partial()
        {
            return PartialView("contact_partial");
        }
        public ActionResult Required()
        {
            return PartialView("Required");
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
        public ActionResult contact()
        {
            return View("contact");
        }



        
        [HttpPost]
        public ActionResult adminLogin(apta_admin admin)
        {
            ModelsCMS db = new ModelsCMS();
            var userLoggedIn = db.apta_admins.SingleOrDefault(x => x.Email == admin.Email && x.Password == admin.Password );
            if (userLoggedIn != null)
            {
                ViewBag.message1 = "loggedin";
                ViewBag.triedOne1 = "yes";
                return RedirectToAction("adminHome", "Home", new { Email = admin.Email });
            }
            else
            {
                ViewBag.triedOnce = "yes";
                return View("Error");
            }

        }

        public ActionResult adminHome(string Email)
        {
            ViewBag.Email1 = Email;
           
            return View();
        }
        

    }
}

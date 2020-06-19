using eUseControl.Web.Models.UserDbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.Web.Models;

namespace Top_Infinity.Controllers
{
    public class HomeController : Controller
    {
        UserDBContext db = new UserDBContext();
       
        public ActionResult Index()
        {
            return View();
        }
         

        public ActionResult About()
        {
            return View();
        }

       
        public ActionResult Contacts()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        
        public ActionResult Products()
        {
            ViewBag.Message = "Your products page.";
            return View();
        }
    }
}
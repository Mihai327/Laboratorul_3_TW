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

        [Authorize(Roles = "Admin")]
        public ActionResult getUserList()
        {
            var user = db.User11.ToList();
            return View(user);
        }

        [Authorize(Roles = "Admin,Utilizator")]
        public ActionResult About()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Utilizator")]
        public ActionResult Contacts()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        [Authorize(Roles = "Admin,Utilizator")]
        public ActionResult Products()
        {
            ViewBag.Message = "Your products page.";
            return View();
        }
    }
}
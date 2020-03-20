using eUseControl.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Collections.Specialized.BitVector32;

namespace eUseControl.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult CreateAcount()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Products()
        {
            UserData u = new UserData();
            u.Username = "Client";
            u.Products = new List<string> { "Produs #1", "Produs #2", "Produs #3", "Produs #4" };
            return View(u);
        }


        public ActionResult Contacts()
        {
            return View();
        }

    }
}
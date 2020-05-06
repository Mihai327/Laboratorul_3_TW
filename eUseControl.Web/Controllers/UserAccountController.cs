using eUseControl.Web.Models;
using eUseControl.Web.Models.UserDbModel;
using System.Data.Entity.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace eUseControl.Web.Controllers
{
    public class UserAccountController : Controller
    {
        DataBase_TopInfinityEntities1 objDataBase_TopInfinityEntities1 = new DataBase_TopInfinityEntities1();

        // GET: UserAccount
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {   
            UserRegisterModel objUserRegisterModel = new UserRegisterModel();
            return View(objUserRegisterModel);
        }

        [HttpPost]
        public ActionResult Register(UserRegisterModel objUserRegisterModel)
        {
            if(ModelState.IsValid)
            {
                if (!objDataBase_TopInfinityEntities1.Users.Any(model => model.EmailAdress == objUserRegisterModel.EmailAdress))
                {
                    User objUser = new Models.UserDbModel.User();
                    objUser.FirstName = objUserRegisterModel.FirstName;
                    objUser.LastName = objUserRegisterModel.LastName;
                    objUser.EmailAdress = objUserRegisterModel.EmailAdress;
                    objUser.Username = objUserRegisterModel.Username;
                    objUser.Password = objUserRegisterModel.Password;
                    objDataBase_TopInfinityEntities1.Users.Add(objUser);
                    objDataBase_TopInfinityEntities1.SaveChanges();
                    Session["EmailAdress"] = objUserRegisterModel.EmailAdress;
                    return RedirectToAction("Index", "Home");

                }else 
                {
                    ModelState.AddModelError("Error", "Adresa de email introdusă, deja se folosește!");
                    return View();
                }

            }

            return View();
        }

        public ActionResult LogIn()
        {
            UserLoginModel objUserLoginModel = new UserLoginModel();
            return View(objUserLoginModel);
        }

        [HttpPost]
        public ActionResult LogIn(UserLoginModel objUserLoginModel)
        {
            if(ModelState.IsValid)
            {
                if (objDataBase_TopInfinityEntities1.Users.Where(model => model.EmailAdress == objUserLoginModel.EmailAdress && model.Username == objUserLoginModel.Username && model.Password == objUserLoginModel.Password).FirstOrDefault() == null)
                {
                    ModelState.AddModelError("Error", "*Adresa electronica, Username-ul sau Parola nu corespund!");
                    return View();
                }
                else 
                {
                    Session["EmailAdress"] = objUserLoginModel.EmailAdress;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}
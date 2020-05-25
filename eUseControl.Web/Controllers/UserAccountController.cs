using eUseControl.Web.Models;
using eUseControl.Web.Models.UserDbModel;

using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace eUseControl.Web.Controllers
{
    
    public class UserAccountController : Controller
    {
        UserDBContext UserDBContext = new UserDBContext();

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
                if (!UserDBContext.User11.Any(model => model.EmailAdress == objUserRegisterModel.EmailAdress))
                {
                    User11 objUser = new User11();
                    objUser.FirstName = objUserRegisterModel.FirstName;
                    objUser.LastName = objUserRegisterModel.LastName;
                    objUser.EmailAdress = objUserRegisterModel.EmailAdress;
                    objUser.Username = objUserRegisterModel.Username;
                    objUser.Password = objUserRegisterModel.Password;
                    UserDBContext.User11.Add(objUser);
                    UserDBContext.SaveChanges();
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
        public ActionResult LogIn(UserLoginModel objUserLoginModel, string returnUrl)
        {
            
            if(ModelState.IsValid)
            {

                if (UserDBContext.User11.Where(model => model.EmailAdress == objUserLoginModel.EmailAdress && model.Username == objUserLoginModel.Username && model.Password == objUserLoginModel.Password).FirstOrDefault() == null)
                {
                    ModelState.AddModelError("Error", "*Adresa electronica, Username-ul sau Parola nu corespund!");
                    return View();
                }
                else 
                {
                    FormsAuthentication.SetAuthCookie(objUserLoginModel.Username, false);
                    if(Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/") && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        Session["EmailAdress"] = objUserLoginModel.EmailAdress;
                        return RedirectToAction("Index", "Home");
                    }
                    
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
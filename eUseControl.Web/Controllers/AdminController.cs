using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.Web.Models.UserDbModel;
using eUseControl.Web.Models;

namespace eUseControl.Web.Controllers
{
    public class AdminController : Controller
    {
        UserDBContext db = new UserDBContext();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Dashboard()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Notifications()
        {
            return View();
        }

        /* Gestionarea listei de utilizatori */
        // Se extrage lista de Utilizatori din Baza de date
        [Authorize(Roles = "Admin")]
        public ActionResult getUserList()
        {
            var user = db.User11.ToList();
            return View(user);
        }

        // Se editează utilizatorul din Baza de date
        [Authorize(Roles = "Admin")]
        public ActionResult Edit_User(int id)
        {
            var user = db.User11.Where(x => x.Id == id).First();
            return View(user);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit_User(User11 model)
        {
            var user = db.User11.Where(x => x.Id == model.Id).First();
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.EmailAdress = model.EmailAdress;
            user.Username = model.Username;
            user.Password = model.Password;
            db.SaveChanges();
            return View("getUserList");
        }


        [Authorize(Roles = "Admin")]
        public ActionResult Datails_User()
        {
            return View();
        }

        // Se sterge un User din Baza de date
        [Authorize(Roles = "Admin")]
        public ActionResult Delete_User(int id)
        {
            var user = db.User11.Where(x => x.Id == id).First(); // Se cauta in Database userul cu Id egal cu ID si se stocheaza in variabla user
            db.User11.Remove(user); // Se sterge utilizatorul din tabela Users Din Baza de date
            db.SaveChanges(); //Se salveaza modificarile in Baza de date

            // se extrag utilizatorii ramasi in baza de date si se afiseaza prin variabila actual_users
            var actual_users = db.User11.ToList();
            return View("getUserList", actual_users); // Se returneaza "getUserList" pentru a nu se modifica pagina in timpul stergerii userului
        }

        // Se adauga un utilizator in Baza de date
        [Authorize(Roles = "Admin")]
        public ActionResult Add_User()
        {
            UserRegisterModel objUserRegisterModel = new UserRegisterModel();
            return View(objUserRegisterModel);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Add_User(UserRegisterModel objUserRegisterModel)
        {
            if (ModelState.IsValid)
            {
                if (!db.User11.Any(model => model.EmailAdress == objUserRegisterModel.EmailAdress))
                {
                    User11 objUser = new User11();
                    objUser.FirstName = objUserRegisterModel.FirstName;
                    objUser.LastName = objUserRegisterModel.LastName;
                    objUser.EmailAdress = objUserRegisterModel.EmailAdress;
                    objUser.Username = objUserRegisterModel.Username;
                    objUser.Password = objUserRegisterModel.Password;
                    db.User11.Add(objUser);
                    db.SaveChanges();

                    return RedirectToAction("getUserList", "Admin");

                }
                else
                {
                    ModelState.AddModelError("Error", "Adresa de email introdusă, deja se folosește!");
                    return View();
                }

            }

            return View();
        }
    }
}
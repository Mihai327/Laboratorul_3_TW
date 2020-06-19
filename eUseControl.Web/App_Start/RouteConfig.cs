using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace eUseControl.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "SignUp",
               url: "{controller}/{action}",
               defaults: new { controller = "Login", action = "SignUp" }
           );

            routes.MapRoute(
               name: "CreateAcount",
               url: "{controller}/{action}",
               defaults: new { controller = "UserAccount", action = "Register" }
           );

            routes.MapRoute(
               name: "About",
               url: "{controller}/{action}",
               defaults: new { controller = "Home", action = "About" }
           );

            routes.MapRoute(
               name: "Products",
               url: "{controller}/{action}",
               defaults: new { controller = "Home", action = "Products" }
           );

            routes.MapRoute(
              name: "Contacts",
              url: "{controller}/{action}",
              defaults: new { controller = "Home", action = "Contacts" }
          );

            routes.MapRoute(
              name: "getUserList",
              url: "{controller}/{action}",
              defaults: new { controller = "Admin", action = "getUserList" }
          );

            routes.MapRoute(
              name: "Dashboard",
              url: "{controller}/{action}",
              defaults: new { controller = "Admin", action = "Dashboard" }
          );

            routes.MapRoute(
              name: "Notifications",
              url: "{controller}/{action}",
              defaults: new { controller = "Admin", action = "Notifications" }
          );

            routes.MapRoute(
              name: "Edit_User",
              url: "{controller}/{action}",
              defaults: new { controller = "Admin", action = "Edit_User" }
          );

            routes.MapRoute(
              name: "Datails_User",
              url: "{controller}/{action}",
              defaults: new { controller = "Admin", action = "Datails_User" }
          );

            routes.MapRoute(
              name: "Add_User",
              url: "{controller}/{action}",
              defaults: new { controller = "Admin", action = "Add_User" }
          );
        }
    }
}

using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartupAttribute(typeof(eUseControl.Web.Startup))]
namespace eUseControl.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }

    }
}
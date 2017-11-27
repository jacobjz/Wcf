using Autofac;
using Autofac.Integration.Wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using WcfZadanko.Services;

namespace WcfZadanko
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            /*ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<WniosekService>().As<IWniosekService>();
            AutofacHostFactory.Container = builder.Build();*/


            var builder = new ContainerBuilder();
            builder.RegisterType<WcfZadanko.DbService>();

            builder.RegisterType<WniosekService>()
                   .As<IWniosekService>();
            AutofacHostFactory.Container = builder.Build();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
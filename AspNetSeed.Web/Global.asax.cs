using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using Ninject.Web.Common.WebHost;
using Ninject;
using System.Reflection;

namespace AspNetSeed.Web
{
    public class Global : NinjectHttpApplication
    {
        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            RegisterServices(kernel);
            return kernel;
        }

        private void RegisterServices(StandardKernel kernel)
        {
            kernel.Load(Assembly.GetExecutingAssembly());
        }

        //void Application_Start(object sender, EventArgs e)
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();

            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
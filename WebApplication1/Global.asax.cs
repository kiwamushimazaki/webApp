using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer<MvcBasicContext>(new MvcBasicInitializer());
            Database.SetInitializer<MvcBasicContext2>(new MvcBasicInitializer2());
            Database.SetInitializer<MvcBasicContext3>(new MvcBasicInitializer3());
        }
    }
}

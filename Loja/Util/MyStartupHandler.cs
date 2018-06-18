using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core;

namespace Loja.Util
{

    public class MyStartupHandler : IApplicationEventHandler
    {
        public void OnApplicationStarted(
            UmbracoApplicationBase umbracoApplication,
            ApplicationContext applicationContext)
        {
            //Create a custom route
            RouteTable.Routes.MapRoute(
                "test",
                "Products/{action}/{id}",
                new
                {
                    controller = "Product",
                    action = "Index",
                    id = UrlParameter.Optional
                });
        }
        public void OnApplicationInitialized(
            UmbracoApplicationBase umbracoApplication,
            ApplicationContext applicationContext)
        {
        }
        public void OnApplicationStarting(
            UmbracoApplicationBase umbracoApplication,
            ApplicationContext applicationContext)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplicationDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "my-nam-quan",
               url: "my-nam-quan",
               defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
           );

            routes.MapRoute(
              name: "MY_URL",
              url: "chi-tiet-{name}-{id}",
              defaults: new { controller = "Home", action = "Detail", name= UrlParameter.Optional, id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

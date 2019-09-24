using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookMyShow
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes(); 

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Movie", action = "MovieList", id = UrlParameter.Optional }
            );

            //routes.MapRoute(
            //    name: "Default1",
            //    url: "{controller}/{action}/{id}/{name}",
            //    defaults: new { controller = "Movie", action = "ShowMovies", id = UrlParameter.Optional }
            //);
        }
    }
}

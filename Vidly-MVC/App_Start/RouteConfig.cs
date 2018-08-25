using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Details",
                "customers/Details/{id}",
                new { controller = "customers", action = "Details", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                "GetMovies",
                "Movies",
                new { controller = "Movies", action = "MoviesPage" });

            routes.MapRoute(
                "customerIndex",
                "customers",
                new { controller = "Customers", action = "Index", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

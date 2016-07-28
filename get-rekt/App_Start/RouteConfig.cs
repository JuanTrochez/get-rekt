using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace get_rekt
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Home
            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //Video 
            routes.MapRoute(
                name: "WatchVideo",
                url: "video/{id}",
                defaults: new { controller = "Video", action = "Watch", id = UrlParameter.Optional },
                constraints: new { id = @"\d+" }
            );

            routes.MapRoute(
                name: "CategoryVideo",
                url: "video/category/{id}",
                defaults: new { controller = "Video", action = "CategoryVideo", id = UrlParameter.Optional },
                constraints: new { id = @"\d+" }
            );

            routes.MapRoute(
                name: "CheckVideo",
                url: "video/liste-attente",
                defaults: new { controller = "Video", action = "WaitList" }
            );

            routes.MapRoute(
                name: "AddVideo",
                url: "video/ajouter",
                defaults: new { controller = "Video", action = "AddVideo" }
            );

            routes.MapRoute(
                name: "SubmitVideo",
                url: "{controller}/{action}",
                defaults: new { controller = "Video", action = "AddVideo" }
            );

            //Category 
            routes.MapRoute(
                name: "Category",
                url: "video/{categoryId}",
                defaults: new { controller = "Category", action = "Index", categoryId = UrlParameter.Optional },
                constraints: new { categoryId = @"\d+" }
            );

            //Contribute
            routes.MapRoute(
                name: "Contribute",
                url: "participe",
                defaults: new { controller = "Contribute", action = "Index" }
            );
        }
    }
}

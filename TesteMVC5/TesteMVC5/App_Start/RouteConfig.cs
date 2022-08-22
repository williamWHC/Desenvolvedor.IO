using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TesteMVC5
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Configuração para utilizar o atributos na controllers.
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Cliente",
                url: "cliente/{controller}/{action}/{id}",
                defaults: new { controller = "Cliente", action = "Cadastro", id = UrlParameter.Optional }

            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}

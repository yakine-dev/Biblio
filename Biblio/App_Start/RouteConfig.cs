using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Biblio
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //biblio.com/livre/index => Controller = LivreController Action= Index parametre = null
            //biblio.com/livre/ => Controller = LivreController Action= Index parametre = null
            //biblio.com/livre/Edite/2 => Controller = LivreController Action= Edite parametre = 2 Edite(2)
            //biblio.com/ => Controller = HomeController Action= Index parametre = null

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

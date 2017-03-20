using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Quiron.LojaVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                // Foi necessário alterar a rota de HOME para PRODUTO para que a página seja encontrada independente de qual tela do projeto eu execute o debug.
                defaults: new { controller = "Produtos", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

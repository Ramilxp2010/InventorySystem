using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Routing;

namespace InventorySystem.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Конфигурация и службы веб-API

            config.Services.Replace(typeof(IContentNegotiator), new MyNegotiator());
            // Маршруты веб-API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "GetRoute",
                routeTemplate: "api/{controller}/{action}/{showIsDelete}",
                defaults: new { showIsDelete = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "GetByIdRoute",
                routeTemplate: "api/{controller}/{action}/byid/{id}"
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}

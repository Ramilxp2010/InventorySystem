using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace InventorySystem.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Конфигурация и службы веб-API

            // Маршруты веб-API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "GetRoute",
                routeTemplate: "api/{controller}/{action}/{showIsDelete}",
                defaults: new { showIsDelete = RouteParameter.Optional }
            );
            
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

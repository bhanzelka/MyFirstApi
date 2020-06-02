using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyFirstApi.Configuration
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Atribute Routing
           // config.MapHttpAttributeRoutes();


           /* config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );*/

            // Convention-based routing
            config.Routes.MapHttpRoute(
               name: "DefaultApi",
               routeTemplate: "api/{controller}/{identiier}",
               defaults: new {controller="Values", identifier = RouteParameter.Optional}
               );
        }
    }
}
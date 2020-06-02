using System.Web.Http;

namespace MyFirstApi.Configuration
{
    public static void Register(HttpConfiguration config)
    {
        config.MapHttpAttributeRoutes();


        config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional }
            );
    }
}



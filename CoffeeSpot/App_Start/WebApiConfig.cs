using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CoffeeSpot.App_Start;
using CoffeeSpot.Infrastructure;

namespace CoffeeSpot
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Register Unity with Web API.
            var container = IoCConfigurator.ConfigureUnityContainer();

            config.DependencyResolver = new UnityWebApiDependencyResolver(container);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

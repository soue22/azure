﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BoVoyage.UIL
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuration et services API Web

            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
               name: "ApiPays",
               routeTemplate: "api/{controller}/{id}/{idPays}"
           );
            config.Routes.MapHttpRoute(
              name: "ApiVoyageRegions",
              routeTemplate: "api/{controller}/{id}/{idRegions}",
              defaults: new { id = RouteParameter.Optional }
          );
        }
    }
}

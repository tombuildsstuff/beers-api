using System.Web.Http;

namespace BeersApi
{
    public class RouteConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute("Default", "{controller}/{id}", new {id = RouteParameter.Optional});
        }
    }
}

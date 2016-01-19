using System.Web;
using System.Web.Http;

namespace BeersApi
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            var config = GlobalConfiguration.Configuration;
            CastleConfig.Configure(config);
            RouteConfig.Register(config);
        }
    }
}

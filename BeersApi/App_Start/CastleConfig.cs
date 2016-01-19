using System.Web.Http;
using BeersApi.DependencyInjection;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace BeersApi
{
    public static class CastleConfig
    {
        private static IWindsorContainer _container;

        public static void Configure(HttpConfiguration configuration)
        {
            _container = new WindsorContainer().Install(FromAssembly.This());
            var dependencyResolver = new WindsorDependencyResolver(_container);
            configuration.DependencyResolver = dependencyResolver;
        }
    }
}
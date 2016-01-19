using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Dependencies;
using Castle.MicroKernel.Lifestyle;
using Castle.Windsor;

namespace BeersApi.DependencyInjection
{
    public class WindsorDependencyResolver : IDependencyResolver
    {
        private readonly IWindsorContainer _container;

        public WindsorDependencyResolver(IWindsorContainer container)
        {
            _container = container;
        }

        public IDependencyScope BeginScope()
        {
            return new WindsorDependencyScope(_container);
        }

        public object GetService(Type serviceType)
        {
            return _container.Kernel.HasComponent(serviceType) ? _container.Resolve(serviceType) : null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return !_container.Kernel.HasComponent(serviceType) ? new object[0] : _container.ResolveAll(serviceType).Cast<object>();
        }

        public void Dispose()
        {
            _container.Dispose();
        }

        private class WindsorDependencyScope : IDependencyScope
        {
            private readonly IWindsorContainer _container;
            private readonly IDisposable _scope;

            public WindsorDependencyScope(IWindsorContainer container)
            {
                _container = container;
                _scope = container.BeginScope();
            }

            public object GetService(Type serviceType)
            {
                return _container.Kernel.HasComponent(serviceType) ? _container.Resolve(serviceType) : null;
            }

            public IEnumerable<object> GetServices(Type serviceType)
            {
                return _container.ResolveAll(serviceType).Cast<object>();
            }

            public void Dispose()
            {
                _scope.Dispose();
            }
        }
    }
}
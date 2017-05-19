using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;

namespace CoffeeSpot.Infrastructure
{
    public class UnityWebApiDependencyResolver : IDependencyResolver
    {
        private readonly IUnityContainer _container;

        public UnityWebApiDependencyResolver(IUnityContainer container)
        {
            this._container = container;
        }

        public IDependencyScope BeginScope()
        {
            var child = _container.CreateChildContainer();
            return new UnityWebApiDependencyResolver(child);
        }

        public void Dispose()
        {
            _container.Dispose();
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return _container.Resolve(serviceType);
            } catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _container.ResolveAll(serviceType);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

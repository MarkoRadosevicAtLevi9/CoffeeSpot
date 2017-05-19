using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using IDependencyResolver = System.Web.Mvc.IDependencyResolver;

namespace CoffeeSpot.Infrastructure
{
    public class UnityMvcDependencyResolver : IDependencyResolver
    {
        private IUnityContainer container;

        public UnityMvcDependencyResolver(IUnityContainer container)
        {
            this.container = container;
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return container.Resolve(serviceType);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return container.ResolveAll(serviceType);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
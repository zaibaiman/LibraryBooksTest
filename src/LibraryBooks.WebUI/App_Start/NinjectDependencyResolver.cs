using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryBooks.WebUI.App_Start
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel container;

        public IKernel Container 
        {
            get { return container; }
        }

        public NinjectDependencyResolver(IKernel container)
        {
            this.container = container;
        }

        public object GetService(Type serviceType)
        {
            return container.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return container.GetAll(serviceType);
        }
    }
}
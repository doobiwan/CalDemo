using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace CalDemo
{
    public class ContainerConfig
    {
        public static void Configure(Action<System.Web.Http.Dependencies.IDependencyResolver> resolveWebApi, Action<System.Web.Mvc.IDependencyResolver> resolveMvc)
        {
            var builder = new ContainerBuilder();            
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var container = builder.Build();

            resolveWebApi(new AutofacWebApiDependencyResolver(container));
            resolveMvc(new AutofacDependencyResolver(container));
        }
    }
}
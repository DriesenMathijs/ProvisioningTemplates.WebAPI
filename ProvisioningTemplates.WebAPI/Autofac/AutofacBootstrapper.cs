using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using ProvisioningTemplates.Interfaces;
using ProvisioningTemplates.Data;
using ProvisioningTemplates.Service;

namespace ProvisioningTemplates.WebAPI.Autofac
{
    public class AutofacBootstrapper
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(WebApiApplication).Assembly);

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).InstancePerRequest();

            builder.RegisterFilterProvider();
            builder.RegisterSource(new ViewRegistrationSource());

            // Register Services & unit of work
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            builder.RegisterAssemblyTypes(typeof(TestService).Assembly)
                   .Where(t => string.Equals("ProvisioningTemplates.Service", t.Namespace, StringComparison.Ordinal))
                   .AsImplementedInterfaces();

            var container = builder.Build();

            return container;
        }
    }
}
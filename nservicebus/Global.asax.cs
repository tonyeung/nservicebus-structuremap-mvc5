using nservicebus.DependencyResolution;
using NServiceBus;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace nservicebus
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            IContainer container = IoC.Initialize();
            DependencyResolver.SetResolver(new StructureMapDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new StructureMapDependencyResolver(container);

            //Configure.Transactions.Enable();
            //Configure.Serialization.Json();

            //Configure.With()
            //    .DefiningCommandsAs(t => t.Namespace != null && t.Namespace.Contains("messages"))
            //    .StructureMapBuilder(container)
            //    .Log4Net()
            //    .UseTransport<Msmq>()
            //    .UnicastBus()
            //    .CreateBus()
            //    .Start(() => Configure.Instance.ForInstallationOn<NServiceBus.Installation.Environments.Windows>().Install());

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}

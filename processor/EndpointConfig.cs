
namespace processor
{
    using NServiceBus;
    using StructureMap;
    using StructureMap.Configuration.DSL;

	/*
		This class configures this endpoint as a Server. More information about how to configure the NServiceBus host
		can be found here: http://particular.net/articles/the-nservicebus-host
	*/
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Publisher, IWantCustomInitialization
    {
        public void Init()
        {
            Configure.With()
                .DefiningCommandsAs(t => t.Namespace != null && t.Namespace.Contains("messages"))
                .StructureMapBuilder(new Container(new DependencyRegistry()));

            Configure.Serialization.Json();
        }

        public class DependencyRegistry : Registry
        {
            public DependencyRegistry()
            {
                Scan(x =>
                {
                    x.AssembliesFromApplicationBaseDirectory();
                    x.WithDefaultConventions();
                });
            }
        }
    }
}
using Autofac;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.IoC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}
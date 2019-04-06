using Autofac;
using Microsoft.EntityFrameworkCore;

namespace EntityFamework
{
    internal class DemoModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DemoContext>().As<DbContext>();
            base.Load(builder);
        }
    }
}
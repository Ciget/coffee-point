using Autofac;
using CS.CoffePoint.Business.Repositories;

namespace CS.CoffePoint.Business
{
    public class IoCModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<PlaceRepository>().As<IPlaceRepository>();
        }
    }
}

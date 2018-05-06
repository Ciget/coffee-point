using Autofac;
using Autofac.Extensions.DependencyInjection;
using CS.CoffePoint.Business;
using CS.CoffePoint.Business.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace CS.CoffeePoint.Tests
{
    public class BaseTest
    {
        protected AutofacServiceProvider ServiceProvider;

        [SetUp]
        public void Setup()
        {
            var configurationBuilder = new ConfigurationBuilder()
                .Build();

            IServiceCollection collection = new ServiceCollection();
            collection.AddTransient<IConfiguration>(provider => configurationBuilder);

            var cb = new ContainerBuilder();
            cb.RegisterModule(new IoCModule());

            cb.Populate(collection);
            var container = cb.Build();

            ServiceProvider = new AutofacServiceProvider(container);
        }
    }
}

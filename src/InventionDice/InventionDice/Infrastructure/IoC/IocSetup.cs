using System;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace InventionDice.Infrastructure.IoC
{
    public class IocSetup
    {
        public IocSetup()
        {
            ServiceCollection = new ServiceCollection();
        }

        public ServiceCollection ServiceCollection { get; }

        public void Setup()
        {
            ServiceCollection.Scan(scan => scan
                .FromAssemblyOf<App>()
                .AddClasses()
                .AsImplementedInterfaces()
                .WithTransientLifetime());

            ServiceCollection.AddMediatR(typeof(App).Assembly);
        }

        public IServiceProvider GetProvider() => ServiceCollection.BuildServiceProvider();
    }
}

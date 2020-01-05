using System;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using InventionDice.Services.Navigation;

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

            ServiceCollection.AddSingleton((serviceProvider) => new ViewModelFactory(serviceProvider.GetService));
            ServiceCollection.AddMediatR(typeof(App).Assembly);
            ServiceCollection.AddAutoMapper(typeof(App).Assembly);
        }

        public IServiceProvider GetProvider() => ServiceCollection.BuildServiceProvider();
    }
}

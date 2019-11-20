using InventionDice.AppFiles.Startup;
using InventionDice.Infrastructure.IoC;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Xamarin.Forms;

namespace InventionDice
{
    public partial class App : Application
    {
        private readonly IocSetup iocSetup;
        public App()
        {
            InitializeComponent();
            iocSetup = new IocSetup();
        }

        protected override void OnStart()
        {
            iocSetup.Setup();
            var provider = iocSetup.GetProvider();
            provider.GetService<IMediator>().Send(new StartupRequest());
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

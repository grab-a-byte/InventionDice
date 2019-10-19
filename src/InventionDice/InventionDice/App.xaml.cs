using InventionDice.Data;
using InventionDice.Infrastructure;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InventionDice
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            var pathHelper = new FileSystemPathHelper();
            var migrator = new LocalDatabaseMigrator(pathHelper);

            migrator.Upgrade();
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

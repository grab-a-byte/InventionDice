using System.Threading;
using System.Threading.Tasks;
using InventionDice.Data;
using MediatR;
using Xamarin.Forms;

namespace InventionDice.AppFiles.Startup
{
    public class StartupHandler : IRequestHandler<StartupRequest, StartupResponse>
    {
        private readonly ILocalDatabaseMigrator localDatabaseMigrator;

        public StartupHandler(ILocalDatabaseMigrator localDatabaseMigrator)
        {
            this.localDatabaseMigrator = localDatabaseMigrator;
        }
        public Task<StartupResponse> Handle(StartupRequest request, CancellationToken cancellationToken)
        {
            Application.Current.MainPage = new MainPage();
            localDatabaseMigrator.Upgrade();
            return Task.FromResult(new StartupResponse());
        }
    }
}

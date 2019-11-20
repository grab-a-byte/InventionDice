using System.Threading;
using System.Threading.Tasks;
using InventionDice.Data;
using InventionDice.Services.Navigation;
using InventionDice.ViewModels;
using MediatR;

namespace InventionDice.AppFiles.Startup
{
    public class StartupHandler : IRequestHandler<StartupRequest, StartupResponse>
    {
        private readonly ILocalDatabaseMigrator localDatabaseMigrator;
        private readonly INavigationService navigationService;

        public StartupHandler(ILocalDatabaseMigrator localDatabaseMigrator, INavigationService navigationService)
        {
            this.localDatabaseMigrator = localDatabaseMigrator;
            this.navigationService = navigationService;
        }
        public Task<StartupResponse> Handle(StartupRequest request, CancellationToken cancellationToken)
        {
            this.navigationService.NavigateTo<MainViewModel>();
            localDatabaseMigrator.Upgrade();
            return Task.FromResult(new StartupResponse());
        }
    }
}

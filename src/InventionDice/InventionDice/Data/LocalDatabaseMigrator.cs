using DbUp;
using DbUp.Engine;
using InventionDice.Infrastructure;
using System.Reflection;

namespace InventionDice.Data
{
    public class LocalDatabaseMigrator : ILocalDatabaseMigrator
    {
        private readonly IFileSystemPathHelper pathHelper;

        public LocalDatabaseMigrator(IFileSystemPathHelper pathHelper)
        {
            this.pathHelper = pathHelper;
        }

        public bool Upgrade()
        {
            UpgradeEngine upgrader = DeployChanges
                .To
                .SQLiteDatabase(GetConnectionString())
                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                .Build();

            DatabaseUpgradeResult result = upgrader.PerformUpgrade();

            return result.Successful;

        }

        private string GetConnectionString() => $"Data Source = {pathHelper.GetAppDataFilePath(ApplicationConstants.DatabaseName)}";
    }
}

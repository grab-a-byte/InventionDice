using InventionDice.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace InventionDice.Data
{
    internal class AppDatabaseContext : DbContext
    {
        private readonly IFileSystemPathHelper pathHelper;

        public AppDatabaseContext(IFileSystemPathHelper pathHelper)
        {
            this.pathHelper = pathHelper;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={this.pathHelper.GetAppDataFilePath(ApplicationConstants.DatabaseName)}");
    }
}

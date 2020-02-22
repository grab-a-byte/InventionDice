using InventionDice.Data.Models;
using InventionDice.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace InventionDice.Data
{
    public class AppDatabaseContext : DbContext
    {
        private readonly IFileSystemPathHelper pathHelper;

        public AppDatabaseContext(IFileSystemPathHelper pathHelper)
        {
            this.pathHelper = pathHelper;
        }

        public DbSet<Dice> Dice { get; set; }
        public DbSet<DiceSet> DiceSets { get; set; }
        public DbSet<DiceValue> DiceValues { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(AppDatabaseContext).Assembly);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={this.pathHelper.GetAppDataFilePath(ApplicationConstants.DatabaseName)}");
    }
}

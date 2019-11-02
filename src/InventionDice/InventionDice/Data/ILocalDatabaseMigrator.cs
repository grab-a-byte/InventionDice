namespace InventionDice.Data
{
    public interface ILocalDatabaseMigrator
    {
        bool Upgrade();
    }
}
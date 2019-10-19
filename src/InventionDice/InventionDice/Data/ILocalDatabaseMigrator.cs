namespace InventionDice.Data
{
    internal interface ILocalDatabaseMigrator
    {
        bool Upgrade();
    }
}
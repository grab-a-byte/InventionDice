namespace InventionDice.Infrastructure
{
    internal interface IFileSystemPathHelper
    {
        string GetAppDataFilePath(string filename);
    }
}
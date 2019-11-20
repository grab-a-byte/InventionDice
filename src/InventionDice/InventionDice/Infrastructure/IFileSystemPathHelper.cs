namespace InventionDice.Infrastructure
{
    public interface IFileSystemPathHelper
    {
        string GetAppDataFilePath(string filename);
    }
}
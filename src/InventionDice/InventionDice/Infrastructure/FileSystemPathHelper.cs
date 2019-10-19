using Xamarin.Essentials;

namespace InventionDice.Infrastructure
{
    internal class FileSystemPathHelper : IFileSystemPathHelper
    {
        public string GetAppDataFilePath(string filename)
        {
            return $@"{FileSystem.AppDataDirectory}\{filename}";
        }
    }
}

using Xamarin.Essentials;

namespace InventionDice.Infrastructure
{
    public class FileSystemPathHelper : IFileSystemPathHelper
    {
        public string GetAppDataFilePath(string filename)
        {
            return $@"{FileSystem.AppDataDirectory}\{filename}";
        }
    }
}

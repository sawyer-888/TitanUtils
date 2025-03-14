using System.IO;
using System.Threading.Tasks;

namespace TitanUtilsLib.Utils
{
    public static class FileUtils
    {
        public static async Task WriteFileAsync(string path, string content) => await File.WriteAllTextAsync(path, content);

        public static async Task<string> ReadFileAsync(string path) => await File.ReadAllTextAsync(path);
    }
}

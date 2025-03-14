using System;
using System.IO;

namespace TitanUtilsLib.Utils
{
    public static class LoggingUtils
    {
        private static readonly string logFilePath = "TitanUtils.log";

        public static void Log(string message)
        {
            string logEntry = $"[{DateTime.UtcNow}] {message}";
            File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
            Console.WriteLine(logEntry);
        }
    }
}

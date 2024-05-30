using System;
using System.Text;

namespace Adapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Logger consoleLogger = new Logger();
            consoleLogger.Log("Це логове повідомлення");
            consoleLogger.Error("Це повідомлення про помилку");
            consoleLogger.Warn("Це попереджувальне повідомлення");

            string filePath = "log.txt";
            FileLoggerAdapter fileLogger = new FileLoggerAdapter(filePath);
            fileLogger.Log("Це логове повідомлення (файл)");
            fileLogger.Error("Це повідомлення про помилку (файл)");
            fileLogger.Warn("Це попереджувальне повідомлення (файл)");

            Console.WriteLine($"Повідомлення збережено у файлі {filePath}");
        }
    }
}
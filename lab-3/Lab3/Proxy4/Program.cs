using Proxy4;
using System;
using System.IO;
using System.Text;

namespace Proxy4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            string filePath = "example.txt";

            // Створення файлу для тестування
            System.IO.File.WriteAllText(filePath, "Hello\nWorld\nThis is a test file.");

            // Використання проксі для логування
            ITextReader checker = new SmartTextChecker(filePath);
            checker.ReadFile();

            // Використання проксі для обмеження доступу
            ITextReader locker = new SmartTextReaderLocker(filePath, @"test\.txt$");
            locker.ReadFile();

            // Використання проксі для обмеження доступу (приклад з доступом)
            ITextReader lockerWithAccess = new SmartTextReaderLocker(filePath, @"example\.txt$");
            lockerWithAccess.ReadFile();
        }
    }
}
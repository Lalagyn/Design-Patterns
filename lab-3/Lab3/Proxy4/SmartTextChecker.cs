using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy4
{
    public class SmartTextChecker : ITextReader
    {
        private SmartTextReader reader;

        public SmartTextChecker(string filePath)
        {
            this.reader = new SmartTextReader(filePath);
        }

        public char[][] ReadFile()
        {
            Console.WriteLine($"Відкриття файлу: {reader.FilePath}");
            char[][] content = reader.ReadFile();
            Console.WriteLine($"Прочитання файлу: {reader.FilePath}");
            Console.WriteLine($"Закриття файлу: {reader.FilePath}");

            int lineCount = content.Length;
            int charCount = 0;
            foreach (var line in content)
            {
                charCount += line.Length;
            }

            Console.WriteLine($"Кількість рядків: {lineCount}");
            Console.WriteLine($"Кількість символів: {charCount}");

            return content;
        }
    }
}

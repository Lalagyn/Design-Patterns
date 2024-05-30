using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proxy4
{
    public class SmartTextReaderLocker : ITextReader
    {
        private SmartTextReader reader;
        private Regex accessPattern;

        public SmartTextReaderLocker(string filePath, string pattern)
        {
            this.reader = new SmartTextReader(filePath);
            this.accessPattern = new Regex(pattern);
        }

        public char[][] ReadFile()
        {
            if (accessPattern.IsMatch(reader.FilePath))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            else
            {
                return reader.ReadFile();
            }
        }
    }
}

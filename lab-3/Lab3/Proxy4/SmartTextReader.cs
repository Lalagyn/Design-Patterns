using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proxy4
{
    public class SmartTextReader : ITextReader
    {
        public string FilePath { get; }

        public SmartTextReader(string filePath)
        {
            FilePath = filePath;
        }

        public char[][] ReadFile()
        {
            string[] lines = File.ReadAllLines(FilePath);
            char[][] result = new char[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                result[i] = lines[i].ToCharArray();
            }

            return result;
        }
    }
}

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RegexReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            // replace a word from a string

            // replace all 'test' strings from a text file, if the 'test' word is a prefix or a suffix
            using (var reader = new StreamReader(Path.Join(AppContext.BaseDirectory, "../../../", "input.txt")))
            {
                
            }
        }
    }
}

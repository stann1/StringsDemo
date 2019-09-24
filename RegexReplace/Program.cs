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
            var input = "Replace the word start with finish";
            var result = Regex.Replace(input, @"start", "finish");
            Console.WriteLine(result);

            // replace all 'test' strings from a text file, if the 'test' word is a prefix or a suffix
            using (var reader = new StreamReader(Path.Join(AppContext.BaseDirectory, "../../../", "input.txt")))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(Regex.Replace(line, @"test(\w+)|(\w+)test", "$1$2"));
                    line = reader.ReadLine();
                }
            }
        }
    }
}

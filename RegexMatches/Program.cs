using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexMatches
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allWords = File.ReadAllLines(Path.Join(@"../../../","words.txt"));

            using (var reader = new StreamReader(Path.Join(@"../../../", "input.txt")))
            {
                string line = reader.ReadLine();
                var dict = new Dictionary<string, int>();

                while (line != null)
                {
                    foreach (var word in allWords)
                    {
                        if (!dict.ContainsKey(word))
                        {
                            dict[word] = 0;
                        }
                        var regex = Regex.Matches(line, "\\b" + word + "\\b");
                        dict[word] += regex.Count;
                    }
                    
                    line = reader.ReadLine();
                }

                foreach (var pair in dict)
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value}");
                }

            }
        }
    }
}

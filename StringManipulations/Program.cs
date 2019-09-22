using System;
using System.Text;
using System.Text.RegularExpressions;

namespace StringManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today. " +
                          "The PHP compiler is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string words = "PHP, CLR, Microsoft";

            //ForbiddenWordsPlain(text, words);
            //ForbiddenWordsRegex(text, words);
        }

        static void ForbiddenWordsPlain(string text, string words)
        {
            StringBuilder builder = new StringBuilder(text);
            string[] keys = words.Split(',');                //create a list of words

            for (int i = 0; i < keys.Length; i++)
            {
                var word = keys[i].Trim();                 
                string replacement = "".PadLeft(word.Length, '*');
                
                int start = text.IndexOf(word);
                while (start != -1)
                {
                    builder.Replace(word, replacement);       //replace keywords with masks
                    start = text.IndexOf(word, start + 1);
                }
            }

            Console.WriteLine(builder.ToString());
        }

        static void ForbiddenWordsRegex(string text, string words)
        {
            string[] keys = words.Split(',');                //create a list of words

            string result = text;
            foreach (var word in keys)
            {
                string replacement = "".PadLeft(word.Length, '*');
                string pattern = $@"\b{word.Trim()}\b";
                result = Regex.Replace(result, pattern, replacement);            
            }

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Text;
using System.Text.RegularExpressions;

namespace StringManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Replace all words from the list with '*', keeping the length of the string the same
            
            string text = "Microsoft announced its next generation PHP compiler today. " +
                          "The PHP compiler is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string words = "PHP, CLR, Microsoft";

            //ForbiddenWordsPlain(text, words);
            //ForbiddenWordsRegex(text, words);
        }

        static void ForbiddenWordsPlain(string text, string words)
        {
            
        }

        static void ForbiddenWordsRegex(string text, string words)
        {
            
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace RegexSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "Find if any words end with digits like word1234, standalone numbers like 123, or 567 do not count";
            var pattern = @"\w+\d+";
            var hasMatch = Regex.IsMatch(input, pattern);

            Console.WriteLine("Input has word-numbers?: " + hasMatch);

            // find out if the input is a phone number, it must begin with '08' and have exactly 10 digits
            var phone = "0888123456";
            Console.WriteLine("has ten digits?: " + Regex.IsMatch(phone, @"\d{10}"));
            Console.WriteLine("is phone? " + Regex.IsMatch(phone, @"^08\d{8}"));
        }
    }
}

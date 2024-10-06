using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program5
    {
        public static void Main(string[] args)
        {
            List<string> substrings = GetAllSubstrings("abc");

            Console.WriteLine("Substrings of \"" + input + "\":");
            foreach (string substring in substrings)
            {
                Console.WriteLine(substring);
            }
        }


        static List<string> GetAllSubstrings(string input)
        {
            List<string> substrings = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j <= input.Length; j++)
                {
                    substrings.Add(input.Substring(i, j - i));
                }
            }

            return substrings;
        }

    }
}

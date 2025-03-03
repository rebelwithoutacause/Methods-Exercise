using System;
using System.Collections.Generic;

namespace _01.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int result = GetVowelsCount(text);
            Console.WriteLine(result);
        }

        static int GetVowelsCount(string text)
        {
            int result = 0;

            
            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            foreach (char letter in text)
            {
                if (vowels.Contains(letter))
                {
                    result++;
                }
            }

            return result;
        }
    }
}

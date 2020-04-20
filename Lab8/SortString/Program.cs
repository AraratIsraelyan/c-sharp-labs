using System;
using System.Linq;

namespace SortString
{
    class Program
    {
        
        static void Main(string[] args)
        {
            String message = "Oh Hi Mark";
            Console.WriteLine(message);
            string[] words = message.Split(" ");
            foreach (var a1 in words)
            {
                Console.Write($"[{a1}]\t");
            }
            Console.WriteLine();
            
            Array.Sort(words);
            foreach (var a1 in words)
            {
                Console.Write($"[{a1}]\t");
            }

            Console.WriteLine();
            string sentence = string.Join(' ', words);
            Console.WriteLine(sentence);
        }
    }
}
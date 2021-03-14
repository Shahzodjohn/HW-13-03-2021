using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vocabulary = { "Telescopes", "Glasses", "Eyes", "Monocles" };
            IEnumerable<string> words = vocabulary.OrderByDescending (v => v);
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

        }
    }
}

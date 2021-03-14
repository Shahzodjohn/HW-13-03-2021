using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 4, 8, 5, 9, 7 };
            IEnumerable<int> res = numbers.Reverse();

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}

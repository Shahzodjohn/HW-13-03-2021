using System;
using System.Collections.Generic;
using System.Linq;

namespace HWLINC2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,-11, -12, -13, -14, -15};
            IEnumerable<int> res = numbers.Select(s=>s);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
                                  
        }
    }
}

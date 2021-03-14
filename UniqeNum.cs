using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Fin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] uniqeNum = { 1, 1, 1, 2, 1, 1 };
            var a = uniqeNum.GroupBy(n => n).Select(g => g.Count() == 1 ? g.Key : 0).Max();
            Console.WriteLine(a);
            
        }
    }
}


using System;
using System.Linq;

namespace ConsoleApp58
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] uniqeNum = { 0, 0, 0.55, 0, 0 };
            var a = uniqeNum.GroupBy(n => n).Select(g => g.Count() == 1 ? g.Key : 0).Max();
            Console.WriteLine(a);

        }
    }
}

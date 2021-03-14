using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp56
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            var positiveNumbers = numbers.Where(x => x > 0).Count();
            var negativeNumbers = numbers.Where(x => x < 0).Sum();
            
            Console.WriteLine(positiveNumbers);
            Console.WriteLine(negativeNumbers);
            


        }
        
                
        
    }
}

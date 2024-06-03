using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 4, 6, 9, 10, 12 };

            var product = numbers.Aggregate((a, b) => a * b );
           

            Console.ReadLine();
        }
    }
}

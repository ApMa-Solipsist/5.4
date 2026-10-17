using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4
{
    internal class Program
    {
        static uint Factorial(uint n)
        {
            if (n <= 2) return 1;
            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            uint i = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(Factorial(i));
        }
    }
}

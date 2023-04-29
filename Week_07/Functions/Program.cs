using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static int result;
        static void Main(string[] args)
        {
            int a = 10;
            int b = 11;
            int r = Sum(a, b);

            Console.WriteLine(r);
            Console.ReadKey();

        }

        static ref int Sum(int a, int b)
        {
            result = a + b;
            return ref result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // fourth method to declare a jugged array, in this method we declare ans also initialize the array.
            int[][] numbers = { new int[3] {1,2,3 }, new int[4] {1,2,3,4 } };
            int count = 0;
            foreach (int[] temp in numbers)
            {
                Console.WriteLine("inner array: " + count++);
                foreach (int tempE in temp)
                {
                    Console.Write(tempE + ", ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}

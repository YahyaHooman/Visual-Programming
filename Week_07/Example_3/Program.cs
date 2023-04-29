using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //third method to declare a jugged array
            int[][] numbers = new int[2][] { new int[3], new int[4] };
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write($"ENTER [{i}][{j}]: ");
                    numbers[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

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

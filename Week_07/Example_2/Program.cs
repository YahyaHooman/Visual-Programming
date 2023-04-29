using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // here is the second method to declare a jugged array.
            int[][] numbers;
            numbers = new int[2][];
            numbers[0] = new int[3];
            numbers[1] = new int[4];

            //now using a for loop we get the values from console and assign it to inner arrays
            for (int i = 0; i < numbers.Length; i++)
            {
                for(int j = 0; j<numbers[i].Length; j++)
                {
                    Console.Write($"ENTER [{i}][{j}]: ");
                    numbers[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int count = 0;
            foreach(int[] temp in numbers)
            {
                Console.WriteLine("inner array: " + count++);
                foreach(int tempE in temp)
                {
                    Console.Write(tempE + ", ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}

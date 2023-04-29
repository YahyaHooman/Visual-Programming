using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_JuggedArray_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] nums = new int[3][,];
            nums[0] = new int[3, 3];
            nums[1] = new int[4, 1];
            nums[2] = new int[1, 1];

            // here we initialize the nums[0] = new int[3,3]
            nums[0][0, 0] = 1;
            nums[0][0, 1] = 2;
            nums[0][0, 2] = 3;

            nums[0][1, 0] = 1;
            nums[0][1, 1] = 2;
            nums[0][1, 2] = 3;

            nums[0][2, 0] = 1;
            nums[0][2, 1] = 2;
            nums[0][2, 2] = 3;

            //here we initialize the nums[1] = new int[4,1]
            nums[1][0, 0] = 5;
            nums[1][1, 0] = 5;
            nums[1][2, 0] = 5;
            nums[1][3, 0] = 5;

            // here we initialize the nums[2] = new int[1,1]
            nums[2][0, 0] = 10;

            for(int k = 0; k < nums.Length; k++) // will loop for each innerArray of the jugged array
            {
                Console.WriteLine($"Jugged Array with the index of[{k}]:");
                for(int i = 0; i<nums[k].GetLength(0); i++) // will loop for each row of the innerArray
                {
                    Console.WriteLine();
                    for (int j = 0; j < nums[k].GetLength(1); j++) // will loop for each clm of the innerArray
                    {
                        Console.Write($"innerArray[{i},{j}] = {nums[k][i,j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

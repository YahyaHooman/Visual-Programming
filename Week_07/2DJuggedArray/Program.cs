using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DJuggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] a = new int[4][,];
            a[0] = new int[3, 2];
            a[1] = new int[5, 1];
            a[2] = new int[1, 1];
            a[3] = new int[2,2];


            for (int k = 0; k < a.Length; k++)
            {
                Console.WriteLine($"Jugged Array with the index of[{k}]:");
                for (int i = 0; i < a[k].GetLength(0); i++)
                { 
                    for (int j = 0; j < a[k].GetLength(1); j++) 
                    {
                        Console.Write($"[{k}][{i},{j}] = ");
                        a[k][i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            for (int k = 0; k < a.Length; k++)
            {
                Console.WriteLine($"Jugged Array with the index of[{k}]:");
                for (int i = 0; i < a[k].GetLength(0); i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < a[k].GetLength(1); j++)
                    {
                        Console.Write($"innerArray[{i},{j}] = {a[k][i, j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}

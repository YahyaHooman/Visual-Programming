using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // different ways to define a two dimensional array:
            //first method:
            int[,] matrix_1 = new int[3,4];

            //second mehtod:
            int[,] matrix_2 = new int[4, 2] { {1,2}, {3,4}, {5,6},{7,8 } };

            //third method
            int[,] matrix_3 = { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };


            //--------------------------------working with matrix_2-----------------
            //Console.WriteLine("---------------working with matrix_2----------------");
            //printing all the elements of matrix_2
            //for (int i = 0; i < matrix_2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix_2.GetLength(1); j++)
            //        Console.Write(matrix_2[i, j] + "\t");
            //    Console.WriteLine();
            //}


            //--------------------------------working with matrix_1-----------------
            //Console.WriteLine("---------------working with matrix_1----------------");
            // filling all the indexes of matrix_1 using for loop
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"You are currently filling the {i}th row: ");
            //    for (int j = 0; j < 4; j++)
            //    { 
            //        Console.Write($"[{i}][{j}] = ");
            //        matrix_1[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    Console.WriteLine();
            //}
            // printing all the elements of matrix_1
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //        Console.Write(matrix_1[i, j] + "\t");
            //    Console.WriteLine();
            //}


            //--------------------------------working with matrix_3 with foreach loop-----------------
            Console.WriteLine("---------------working with matrix_3 with for each loop----------------");

            int counter = 0;
            foreach(int element in matrix_3)
            {
                Console.Write(element + "\t");
                counter++;
                if(counter == matrix_3.GetLength(1))
                {
                    counter = 0;
                    Console.WriteLine();
                }
            }


            // -------working with matrix_3, printing all the elements column by columns instead of row by rows-------
            //Console.WriteLine("---------------working with matrix_3----------------");

            //for (int j = 0; j<matrix_3.GetLength(1); j++)
            //{
            //    for (int i = 0; i <matrix_3.GetLength(0); i++)
            //        Console.Write(matrix_3[i, j] + "\t");
            //    Console.WriteLine();
            //}


            //___________________________creating a working with matrix_4____________________________________
            //matrix_4 will be the transpose of the matrix_3

            Console.WriteLine("---------------working with matrix_4----------------");
            int[,] matrix_4 = new int[matrix_3.GetLength(1), matrix_3.GetLength(0)];   

            for (int j = 0; j < matrix_3.GetLength(1); j++)
            {
                for (int i = 0; i < matrix_3.GetLength(0); i++)
                    matrix_4[j, i] = matrix_3[i, j];
            }

            for (int i = 0; i < matrix_4.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_4.GetLength(1); j++)
                    Console.Write(matrix_4[i, j] + "\t");
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}

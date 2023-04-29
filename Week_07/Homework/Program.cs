using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // write a program to perform the basic calculation on two numbers using functions.
            int a, b;
            Console.Write("number_1 = ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("number_2 = ");
            b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nOUTPUT: ");
            Console.WriteLine($"Sum result = {Sum(a, b)}");
            Console.WriteLine($"Sub result = {Sub(a, b)}");
            Console.WriteLine($"Mul result = {Mul(a, b)}");
            Console.WriteLine($"Div result = {Div(a, b)}");

            Console.ReadKey();
        }

        static double Sum(int num1, int num2) => num1+num2;
        static double Sub(int num1, int num2) => num1 - num2;
        static double Div(int num1, int num2) => num1 / num2;
        static double Mul(int num1, int num2) => num1 * num2;

    }
}

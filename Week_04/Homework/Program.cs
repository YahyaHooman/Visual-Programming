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
            int pc; // pc stands for passed credit number
            int cs; // cs stands for current semester that you are
            double p;// p stands for percentage till now
            int numberOfTestCases;

            Console.Write("Enter the number of Test Cases: ");
            numberOfTestCases = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numberOfTestCases; i++)
            {
                Console.WriteLine($"\n\nTEST CASE OF {i}:");
                Console.Write("Please Enter The Number Of Credits You Passed: ");
                pc = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please Enter The Percentage Your scores that you've gained: ");
                p = Convert.ToDouble(Console.ReadLine());
                cs = pc / 20;

                if (cs == 1 || cs == 2 || cs == 3 || cs == 4)
                {
                    Console.WriteLine("\n-------------output----------------");
                    Console.WriteLine($"You are in term {cs}.");

                    if (p <= 75 && p >= 55)
                    {

                        Console.WriteLine("Your percentage is intermediate you have chance to compensate!");
                    }
                    else if (p <= 85 && p > 75)
                    {
                        Console.WriteLine("Your percentage is high you have chance to make it even better!");
                    }
                    else if (p <= 90 && p > 85)
                    {
                        Console.WriteLine("Your percentage is very high you have chance to make it even better!");
                    }
                    else if (p <= 100 && p > 90)
                    {
                        Console.WriteLine("Your percentage is really great Congratulations!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input or may you failed!");
                    }
                }
                else if (cs == 5 || cs == 6)
                {
                    Console.WriteLine("\n-------------output----------------");
                    Console.WriteLine($"You are in term {cs}.");

                    if (p <= 75 && p >= 55)
                    {

                        Console.WriteLine($"Your percentage is intermediate you can boost it to {p + 5}!");
                    }
                    else if (p <= 85 && p > 75)
                    {
                        Console.WriteLine($"Your percentage is high, still you can boost it to {p + 5}!");
                    }
                    else if (p <= 90 && p > 85)
                    {
                        Console.WriteLine($"Your percentage is well still you can boost it to {p + 5}!");
                    }
                    else if (p <= 100 && p > 90)
                    {
                        Console.WriteLine($"Your percentage is great Congratulations!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input or may you failed!");
                    }

                }
                else if (cs == 7 || cs == 8)
                {
                    Console.WriteLine("\n-------------output----------------");
                    Console.WriteLine($"You are in term {cs}.");

                    if (p <= 75 && p >= 55)
                    {

                        Console.WriteLine($"Your percentage is intermediate you have not chance to compensate sorry!");
                    }
                    else if (p <= 85 && p > 75)
                    {
                        Console.WriteLine($"Your percentage is high but you cannot boost it sorry!");
                    }
                    else if (p <= 90 && p > 85)
                    {
                        Console.WriteLine($"Your percentage is well but you cannot boost is sorry!");
                    }
                    else if (p <= 100 && p > 90)
                    {
                        Console.WriteLine($"Your percentage is great Congratulations!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input or may you failed!");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input please try again!");
                }

            }
            Console.ReadLine();
        }
    }
}

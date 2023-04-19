using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tcp, rm, sc = 0; //tpc --> Total passed credits, rm --> remaining credits, sc--> credit of ech subject.
            double cp, gp = 0; // cp--> current percentage, gp --> goal percentage.
            string sb; // sb stands for subject name.

            Console.WriteLine("\nThis program simply helps you to determine whether you can achieve" +
                " a specific goal percentage or not!\nif you could, this will give you average of toatl scores needed to achieve the goal.\n\n");

            Console.WriteLine("\n---------------------PRGRAM'S INPUT--------------------------\n");

            Console.Write("Please Enter the toatl number of credits you've passed: ");
            tcp = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter the total Percentage of your scores you've gained till now: ");
            cp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please Enter the number of credits you haven't passed yet: ");
            rm = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter the goal percentage you want to achieve: ");
            gp = Convert.ToDouble(Console.ReadLine());

            //for(int i = 0; i<rm; i += sc)
            //{
            //    Console.WriteLine($"You have ({rm - i}) more credits to choose!");

            //    Console.Write("Please Enter a subject name: ");
            //    sb = Convert.ToString(Console.ReadLine());


            //    Console.Write($"Now enter the credits of {sb}: ");
            //    sc = Convert.ToInt32(Console.ReadLine());
            //}

            // Formula to solve the solution
            double a = (tcp) * cp / (tcp + rm);
            double b = (double)rm / (tcp + rm);
            double c = gp;
            double x = (c - a) / b;


            Console.WriteLine("\n---------------------PRGRAM'S OUTPUT--------------------------\n");
            if (x <= 100 && x >= 0)
            {
                Console.WriteLine($"At least get {x} Scores in each subject to achieve your goal of {gp}%.");
            }
            else
            {
                Console.WriteLine("Sorry!\ninput is wrong, or you may have not Chance to Achieve your goal percentage.");
            }
            Console.WriteLine("\n--------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}

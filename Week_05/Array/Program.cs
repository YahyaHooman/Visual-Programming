using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // different ways to declare an array in c#
            // first method:
            //------------------------------------
            int[] numbers; 
            numbers = new int[5]{ 1,2,3,4,5};
            foreach(int temp in numbers)
                Console.Write(temp + "\t");
            Console.WriteLine();
            //------------------------------------

            //decond method
            //------------------------------------
            int[] numbers_2 = { 6, 7, 8, 9, 10};
            foreach (int temp in numbers_2)
                Console.Write(temp + "\t");
            Console.WriteLine();
            //------------------------------------

            //Third method
            //------------------------------------
            int[] numbers_3 = new int[5];
            int x = 11;
            for(int i =0; i<5; i++)
            {
                numbers_3[i] = x;
                ++x;
            }
            foreach (int temp in numbers_3)
                Console.Write(temp + "\t");
            Console.WriteLine();
            //------------------------------------
            Console.WriteLine("----------End of this part--------------");

            int[] scores = new int[2];
            string[] lessons = new string[2];
            double sum = 0.0,average = 0.0;

            for(int i = 0; i<2; i++)
            {
                Console.Write("Enter the Lesson's name: ");
                lessons[i] = Console.ReadLine();

                Console.Write("Enter the Lessson's score: ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                sum += scores[i];
            }
            Console.WriteLine($"Total scores: {sum}");
            Console.WriteLine($"Average of scores: {sum / 2}");

            Console.ReadKey();

        }
    }
}

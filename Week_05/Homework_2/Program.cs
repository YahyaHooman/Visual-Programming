using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of subjects: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] Score = new int[n];
            string[] Lessons = new string[n];
            int total = 0;
            double avg = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Subject's name: ");
                Lessons[i] = Console.ReadLine();

                Console.WriteLine("Enter Subject's Score: ");
                Score[i] = Convert.ToInt32(Console.ReadLine());

                total += Score[i];
            }
            avg = (double)total / n;


            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("|   Lessons   |   Score  |   Category  |      State      |");
            Console.WriteLine("|-------------|----------|-------------|-----------------|");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"|{Lessons[i]}       |{Score[i]}        |");
                switch (Lessons[i])
                {
                    case string t when t.StartsWith("P"):
                        Console.Write("Programming  |");
                        break;
                    case string t when t.StartsWith("M"):
                        Console.Write("Mathmathics  |");
                        break;
                    case string t when t.StartsWith("I"):
                        Console.Write("   Islamic   |");
                        break;
                    default:
                        Console.Write("Not Known   |");
                        break;
                }

                if (Score[i] < 45)
                {
                    Console.WriteLine("     FAILED      |");
                }
                else if (Score[i] >= 45 && Score[i] < 55)
                {
                    Console.WriteLine("|Give Examp Again|");
                }
                else
                {
                    Console.WriteLine("      GDOD       |");
                }
            }

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"Total Scores: {total}");
            Console.WriteLine($"Average: {avg}");
            Console.WriteLine("----------------------------------------------------------");
            Console.ReadLine();
        }
    }
}

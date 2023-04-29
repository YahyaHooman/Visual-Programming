using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //      ===============================================
            //    || different ways to define a jugged array in c#:||
            //      ===============================================
            // first method:
            // here we define a jugged array with the name of "university" and we specify that it will hold 3 more arrays inside.
            string[][] university = new string[3][];

            // here we define the 3 more one deminsional arrays by specifying the length of each array which
            // are inside the university array.
            university[0] = new string[4];
            university[1] = new string[3];
            university[2] = new string[5];

            //first array of this university jugged array will hold the teacher names
            university[0][0] = "Tahiri";
            university[0][1] = "Omid";
            university[0][2] = "Jafari";
            university[0][3] = "Nikzad";

            //second array of this university jugged array will hold the worker names.
            university[1][0] = "Shokoh";
            university[1][1] = "Wahid";
            university[1][2] = "Bundyadi";

            //third array of this university jugged array will hold the student names
            university[2][0] = "Danish";
            university[2][1] = "Radween";
            university[2][2] = "Memar";
            university[2][3] = "Rahmat";
            university[2][4] = "Hooman";

            // now we print all the content of the university array using for loop.
            Console.WriteLine("OUTPUT USING FOR LOOP:\n ");
            for (int i = 0; i<university.Length; i++)
            {
                Console.Write($"university [{i}] = [ ");
                for(int j = 0; j<university[i].Length; j++)
                {
                    Console.Write(university[i][j] + ", ");
                }
                Console.Write("]\n");
            }


            // agian we print all the content of the university array using foreach loop in console.
            int count = 0;
            Console.WriteLine("OUTPUT USING FOREACH LOOP:\n ");
            foreach(string[] tempArray in university)
            {
                Console.Write($"university [{count++}] = [ ");
                foreach(string tempElement in tempArray)
                {
                    Console.Write(tempElement + ", ");
                }
                Console.Write("]\n");
            }
            Console.ReadLine();

            // you can find the other ways to define a jugged array in exmaple two in this solution.








        }
    }
}

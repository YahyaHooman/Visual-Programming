using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] namesAndScores = { { "Hooman", "Sima", "Eshwa" }, { "100", "55", "100" } };

            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(namesAndScores[i, j]+"\t");
                Console.WriteLine();
            }
            Console.ReadKey();




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] friends = { "Ahamd", "Ali", "Hooman" };
            foreach(string name in friends)
            {
                switch (name)
                {
                    case string n when n.StartsWith("Ah"):
                        Console.WriteLine($"The name is started with Ah, it may be Ahmad");
                        break;
                    case string n when n.StartsWith("Al"):
                        Console.WriteLine($"The name is started with Al, it may be Ali");
                        break;

                    case string n when n.StartsWith("H"):
                        Console.WriteLine($"The name is started with H, it may be Hooman");
                        break;
                    default:
                        break;
                }
            }



            Console.ReadLine();

        }
    }
}

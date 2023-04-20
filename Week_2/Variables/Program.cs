using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            // this is the class ativity code and simply shows the different types of string concatenation.
            //or string formating.
            double age=0.0;
            string name = "", message;

            Console.Write("Your Name: ");
            name = Console.ReadLine();

            Console.Write("Your Age: ");
            age = Convert.ToDouble(Console.ReadLine());

            message = "Your name is " + name + " and you are " + age + " years old!";
            Console.Write("Printing the text with type 1: ");
            Console.WriteLine(message);

            Console.Write("Printing the text with type 2: ");
            Console.WriteLine("Your name is " + name + " and you are " + age + " years old!");

            Console.Write("Printing the text with type 3: ");
            Console.WriteLine("Your name is {0} and you are {1} years old!", name, age);

            Console.Write("Printing the text with type 4: ");
            Console.WriteLine($"Your name is {name} and you are {age} years old!");


            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            bool keepGoing = true;
            while (keepGoing == true)
            {
                double length;
                double width;

                Console.WriteLine("Length and width calculator!");
                Console.WriteLine("Enter length:");
                length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter width:");
                width = double.Parse(Console.ReadLine());

                Console.WriteLine("The area is " + length * width);
                Console.WriteLine("The perimeter is " + 2 * (length + width));

                string userChoice;
                Console.WriteLine("Continue? (y/n)");
                userChoice = Console.ReadLine();
                if (userChoice == "n")
                {
                    keepGoing = false;
                }
            }
        }
    }
}

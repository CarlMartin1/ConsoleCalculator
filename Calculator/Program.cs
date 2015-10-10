using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare vairable
            int num01;
            int num02;

            //Initialise variable
            {
                Console.WriteLine("Type 1 for Multiply or 2 for Divide!");
                int input = Convert.ToInt32 (Console.ReadLine());

                if (input == 1)
                {
                    Console.Write("Type a number to be multiplied: ");
                    num01 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Type another number: ");
                    num02 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The answer is " + num01 * num02);
                    Console.ReadKey();
                }
                else if (input == 2)
                {
                    Console.Write("Type a number to be divided: ");
                    num01 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Type another number: ");
                    num02 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The answer is " + num01 / num02);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Incorrect value!");
                    Console.ReadKey();
                }
            }

        }
    }
}

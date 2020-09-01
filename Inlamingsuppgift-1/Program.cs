using System;
using System.Diagnostics.CodeAnalysis;

namespace Inlamingsuppgift_1
{
    public class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("Enter your first number! ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your Operator! ");
            string op = Console.ReadLine();

            Console.Write("Enter your second number! ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            if (op == "+")
            {
                Console.WriteLine($"Your answer is {num1} + {num2} = " + (num1 + num2));
            }

            else if (op == "-")
            {
                Console.WriteLine($"Your answer is {num1} - {num2} = " + (num1 - num2));
            }

            else if (op == "*")
            {
                Console.WriteLine($"Your answer is [{num1}] * {num2} = " + (num1 * num2));
            }

            else if (op == "/")
            {
                Console.WriteLine($"Your answer is {num1} / {num2} = " + (num1 * num2));
            }

            else
            {
                Console.WriteLine("Unknown Operator!");
            }
            Console.WriteLine("Press any key to quit: ");
            Console.ReadKey();

           





        }

    }
}

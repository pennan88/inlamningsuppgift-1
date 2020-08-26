using System;
using System.Diagnostics.CodeAnalysis;

namespace Inlamingsuppgift_1
{
    public class Program
    {
        static void Main()
        {


            
            double numberOne = 0;
            double numberTwo = 0;
            double numberThree = 0;

            Console.WriteLine("Test calculator\r");
            Console.WriteLine("------------------------------\n");

            Console.WriteLine("Type your first number");
            numberOne = Convert.ToDouble(Console.ReadLine());
                
            Console.WriteLine("Type your second number");
            numberTwo = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Type your thrid number");
            numberThree = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\t+  Add");
            Console.WriteLine("\t-  Subtract");
            Console.WriteLine("\t*  Multiply");
            Console.WriteLine("\t/  Divide");
            Console.Write("Type your option? ");

            switch (Console.ReadLine())
            {

                case "+":
                    Console.WriteLine($"Your result: {numberOne} + {numberTwo} + {numberThree} = " + (numberOne + numberTwo + numberThree));
                    break;

                case "-":
                    Console.WriteLine($"Your result: {numberOne} - {numberTwo} - {numberThree} = " + (numberOne - numberTwo - numberThree));
                    break;

                case "*":
                    Console.WriteLine($"Your result: {numberOne} * {numberTwo} * {numberThree} = " + (numberOne * numberTwo * numberThree));
                    break;

                case "/":
                    Console.WriteLine($"Your result: {numberOne} / {numberTwo} / {numberThree} = " + (numberOne / numberTwo / numberThree));
                    break;



            }

            Console.Write("Done");
            Console.ReadKey();







        }

    }
}

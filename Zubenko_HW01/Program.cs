using System;

namespace CalculatorDemo
{
    class CalculatorDemo
    {
        static void Main(string[] args)
        {
            double operand1 = new Random().Next(100);
            double operand2 = new Random().Next(10);
            double result;
            string sign ="";
            
            Console.WriteLine("Enter a sign:");
            sign = Console.ReadLine();

            switch(sign)
            {
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine("{0} + {1} = {2}", operand1, operand2, result);
                    break;
                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine("{0} - {1} = {2}", operand1, operand2, result);
                    break;
                case "*":
                    result = operand1 * operand2;
                    Console.WriteLine("{0} * {1} = {2}", operand1, operand2, result);
                    break;
                case "/":
                    if ((operand1 != 0) && (operand2 != 0))
                    {
                        result = operand1/operand2;
                        Console.WriteLine("{0} / {1} = {2}", operand1, operand2, result);
                        break;
                    }
                    else Console.WriteLine("Division by zero!");
                    break;
                default:
                    Console.WriteLine("It's not a sign!");
                    break;
            }
            Console.WriteLine("\n");
        }
    }
}


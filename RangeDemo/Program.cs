using System;
using System.IO;

namespace RangeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number in the range 0-100: ");
            try
            {
                int num = Int32.Parse(Console.ReadLine());
                if (num >= 0 & num <= 14) Console.WriteLine("number {0} in the range [0 - 14]", num);
                else if (num >= 15 & num <= 35) Console.WriteLine("number {0} in the range [15 - 35]", num);
                else if (num >= 36 & num < 50) Console.WriteLine("number {0} in the range [36 - 49]", num);
                else if (num >= 50 & num <= 100) Console.WriteLine("number {0} in the range [50 - 100]", num);
                else Console.WriteLine("number is out the range.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + "\ntry again.");
            }
        }
    }
}

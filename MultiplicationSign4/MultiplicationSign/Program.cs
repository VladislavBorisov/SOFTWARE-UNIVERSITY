using System;
using System.Threading;
using System.Globalization;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double a, b, c;
            byte positiveNumbers = 0;
            Console.Write("Enter the first number a:");
            bool isaDouble = double.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter the second number b:");
            bool isbDouble = double.TryParse(Console.ReadLine(), out b);
            Console.Write("Enter the third number c:");
            bool iscDouble = double.TryParse(Console.ReadLine(), out c);

            if (isaDouble && isbDouble && iscDouble)
            {
                if (Math.Sign(a) == 1)
                {
                    positiveNumbers = (byte)(positiveNumbers + 1);
                }

                if (Math.Sign(b) == 1)
                {
                    positiveNumbers = (byte)(positiveNumbers + 1);
                }

                if (Math.Sign(c) == 1)
                {
                    positiveNumbers = (byte)(positiveNumbers + 1);
                }
                if (positiveNumbers % 2 == 0)
                {
                    Console.WriteLine("The sign of the product is (-)");
                }
                else
                {
                    Console.WriteLine("The sign of the product is (+)");
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry! Some of the values are not double!");
            }
        }
    }
}

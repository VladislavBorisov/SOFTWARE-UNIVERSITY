using System;

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double b = double.Parse(Console.ReadLine());

            double c = new double();

            if (a > b)
            {
                c = b;
                b = a;
                a = c;

                Console.WriteLine();
                Console.WriteLine(a + " " + b);

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(a + " " + b);

            }
        }
    }
}
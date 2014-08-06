using System;


namespace TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three numbers:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("The biggest number is {0}", a);
                }
            }
            if (b > a)
            {
                if (b > c)
                {
                    Console.WriteLine("The biggest number is {0}", b);
                }
            }
            if (c > a)
            {
                if (c > b)
                {
                    Console.WriteLine("The biggest number is {0}", c);
                }
            }
        }
    }
}

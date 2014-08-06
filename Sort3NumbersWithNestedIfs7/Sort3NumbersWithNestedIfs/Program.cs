using System;


namespace Sort3NumbersWithNestedIfs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a 3 numbers :");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            if (a < b)
            {
                if (b < c)
                {
                    if (a < c)
                    {
                        a = c + a;
                        c = a - c;
                        a = a - c;
                    }
                    //else --> a < b < c < a - impossible case
                }
                else if (a < c)
                {
                    a = c + a;
                    c = a - c;
                    a = a - c;

                    a = b + a;
                    b = a - b;
                    a = a - b;
                }
                else
                {
                    a = b + a;
                    b = a - b;
                    a = a - b;
                }
            }
            else if (b < c)
            {
                if (a < c)
                {
                    a = c + a;
                    c = a - c;
                    a = a - c;

                    b = c + b;
                    c = b - c;
                    b = b - c;
                }
                else
                {
                    b = c + b;
                    c = b - c;
                    b = b - c;
                }
            }
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
    }
}

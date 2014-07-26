using System;

namespace MoonGravitation
{
    class МoonGravitation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight: ");
            double weight = double.Parse(Console.ReadLine());

            double weightOnTheMoon = (weight * 0.17);

            Console.WriteLine(weightOnTheMoon);
        }
    }
}

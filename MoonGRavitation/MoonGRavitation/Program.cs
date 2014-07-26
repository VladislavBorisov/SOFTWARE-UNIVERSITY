using System;


namespace MoonGRavitation
{
    class MoonGRavitation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight: ");
            double weight = double.Parse(Console.ReadLine());

            double weightOnTheMoon = (weight * 0.17);
            Console.WriteLine("Your weight on the moon is: " + (weightOnTheMoon) + "kg");
        }
    }
}

using System;


namespace РectanglePerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" Enter width = ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter height = ");
            double height = double.Parse(Console.ReadLine());

            double perimeter = (2 * width) + (2 * height);
            double area = width * height;

            Console.WriteLine("Perimeter of rectangle is " + perimeter);
            Console.WriteLine("Area of rectangle is " + area);
        }
    }
}


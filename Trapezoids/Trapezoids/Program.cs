﻿using System;


namespace Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * h;

            Console.WriteLine("Area of trapezoid is " + area);
        }
    }
}

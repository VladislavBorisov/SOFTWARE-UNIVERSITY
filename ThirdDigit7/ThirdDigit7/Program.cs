using System;


namespace ThirdDigit7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());

            int restNumber = number / 100;
            int thirdDigit = restNumber % 10;

            bool isSeven = thirdDigit == 7;

            Console.WriteLine("Third digit of this number is 7 = " + isSeven);
        }
    }
}

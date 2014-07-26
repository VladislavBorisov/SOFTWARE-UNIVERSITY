using System;


namespace OddEvenNumber
{
    class OddEvenNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Insert number here: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("This number is even.");
            }
            else
            {
                Console.WriteLine("This number is odd.");
            }
        }
    }
}

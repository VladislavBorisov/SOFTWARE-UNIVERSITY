using System;


namespace BitKiller
{
    class BitKiller
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

            string initial = null;
            string result = null;

            for (int i = 0; i < n; i++)
            {
                int currentByte = int.Parse(Console.ReadLine());
                initial = initial + Convert.ToString(currentByte, 2).PadLeft(8, '0');
            }

            for (int i = 0; i < initial.Length; i++)
            {
                if (i % step == 1)
                {
                    continue;
                }

                result = result + initial[i];

            }

            if (result.Length % 8 != 0)
            {
                int padding = 8 - result.Length % 8;
                result = result.PadRight(result.Length + padding, '0');
            }

            for (int i = 0; i + 7 <= result.Length; i += 8)
            {
                string outputByte = result.Substring(i, 8);
                int output = Convert.ToInt32(outputByte, 2);
                Console.WriteLine("Output: " + output);
            }

        }
    }
}

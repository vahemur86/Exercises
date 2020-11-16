using System;

namespace _272
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            CountAndPrint(n);
        }

        static void CountAndPrint(int n)
        {
            bool t = false;
            char[] arr = new char[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = GetRandomChar();
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();

            int bCounter = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 'b')
                {
                    bCounter++;
                }
            }

            if (bCounter >= n / 2)
            {
                t = true;
            }

            Console.WriteLine($"\nAre There 'b's: { t }");
        }

        static char GetRandomChar()
        {
            Random rnd = new Random();
            char randomChar = (char)rnd.Next('a', 'z');

            return randomChar;
        }
    }
}

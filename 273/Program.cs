using System;

namespace _273
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
            char[] arr = new char[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = GetRandomChar();
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();

            int sumOfIndexes = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 'c')
                {
                    sumOfIndexes += i;
                }
            }

            Console.WriteLine($"\nSum of indexes of 'c's: { sumOfIndexes }");
        }

        static char GetRandomChar()
        {
            Random rnd = new Random();
            char randomChar = (char)rnd.Next('a', 'z');

            return randomChar;
        }
    }
}

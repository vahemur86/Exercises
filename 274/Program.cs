using System;

namespace _274
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

            int arithmeticMean = 0;
            int greaterThanHCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 'h')
                {
                    greaterThanHCount++;
                    arithmeticMean += i;
                }
            }

            Console.WriteLine($"\nAriphmetic Mean if indexes which are greater than 'h': { arithmeticMean / greaterThanHCount }");
        }

        static char GetRandomChar()
        {
            Random rnd = new Random();
            char randomChar = (char)rnd.Next('a', 'z');

            return randomChar;
        }
    }
}

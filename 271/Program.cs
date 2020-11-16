using System;

namespace _271
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

            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 'a')
                {
                    counter++;
                    Console.WriteLine(arr[i]);
                }
            }

            Console.WriteLine($"\nCount of 'a's: { counter }");
        }

        static char GetRandomChar()
        {
            Random rnd = new Random();
            char randomChar = (char)rnd.Next('a', 'z');

            return randomChar;
        }
    }
}

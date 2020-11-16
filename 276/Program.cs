using System;

namespace _276
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

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 'y')
                {
                    t = true;
                }
            }

            Console.WriteLine($"\nThere is a 'y': { t }");
        }

        static char GetRandomChar()
        {
            Random rnd = new Random();
            char randomChar = (char)rnd.Next('a', 'z');

            return randomChar;
        }
    }
}

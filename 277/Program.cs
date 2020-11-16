using System;

namespace _277
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
            string futureArrayWithoutDs = string.Empty;

            for (int i = 0; i < n; i++)
            {
                arr[i] = GetRandomChar();
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 'd')
                {
                    futureArrayWithoutDs += arr[i];
                }
            }

            char[] arrWithoutDs = futureArrayWithoutDs.ToCharArray();

            Console.WriteLine("\nArray without 'd's\n");
            for (int i = 0; i < arrWithoutDs.Length; i++)
            {
                Console.WriteLine(arrWithoutDs[i]);
            }
        }

        static char GetRandomChar()
        {
            Random rnd = new Random();
            char randomChar = (char)rnd.Next('a', 'z');

            return randomChar;
        }
    }
}

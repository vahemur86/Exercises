﻿using System;

namespace _280
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
            string futureArray = string.Empty;

            for (int i = 0; i < n; i++)
            {
                arr[i] = GetRandomChar();
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                futureArray += arr[i];

                if (arr[i] == 'f')
                {
                    futureArray += 'f';
                }
            }

            char[] arrWithoutDs = futureArray.ToCharArray();

            Console.WriteLine("\nNew array\n");
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

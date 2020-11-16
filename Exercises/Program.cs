using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 2;
            int k = 3;
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            CountAndPrint(n, h, k);
        }

        static void CountAndPrint(int n, int h, int k)
        {
            bool t = false;
            bool l = false;
            char[] arr = new char[n];
            string futureArrayWithoutDs = string.Empty;

            for (int i = 0; i < n; i++)
            {
                arr[i] = GetRandomChar();
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();

            int counter = 0;
            int bCounter = 0;
            int sumOfIndexes = 0;
            int arithmeticMean = 0;
            int greaterThanHCount = 0;
            int lessThanKCount = 0;

            for (int i = 0; i < n; i++)
            {
                switch (arr[i])
                {
                    case 'a':
                        counter++;
                        Console.WriteLine(arr[i]);
                        break;
                    case 'b':
                        bCounter++;
                        break;
                    case 'c':
                        sumOfIndexes += i;
                        break;
                    case 'y':
                        l = true;
                        break;
                    default:
                        break;
                }

                if (i > h)
                {
                    greaterThanHCount++;
                    arithmeticMean += i;
                }

                if (i < k)
                {
                    lessThanKCount++;
                }

                if (arr[i] != 'd')
                {
                    futureArrayWithoutDs += arr[i];
                }
            }

            if (bCounter >= n / 2)
            {
                t = true;
            }

            Console.WriteLine($"\nCount of 'a's: { counter }");
            Console.WriteLine($"\nAre There 'b's: { t }");
            Console.WriteLine($"\nSum of indexes of 'c's: { sumOfIndexes }");
            Console.WriteLine($"\nAriphmetic Mean if indexes which are greater than 'h': { arithmeticMean / greaterThanHCount }");
            Console.WriteLine($"\nIndexes which are less than 'k': { lessThanKCount }");
            Console.WriteLine($"\nThere is a 'y': { l }");
            Console.WriteLine($"\nArray without 'd's: { futureArrayWithoutDs.ToCharArray() }");
        }

        static char GetRandomChar()
        {
            Random rnd = new Random();
            char randomChar = (char)rnd.Next('a', 'z');

            return randomChar;
        }
    }
}

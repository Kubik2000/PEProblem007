using System;
/*
 * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
 * What is the 10 001st prime number?
 * 
 * Using sieve of Eratosthenes just clear the array and count down the required prime number.
 */
namespace PEProblem007
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime StartTime = DateTime.Now;

            int arraySize = 1000000;
            
            int[] numbers = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = i;
            }

            for (int i = 2; i < arraySize; i++)
            {
                if (numbers[i] != 0)
                {
                    for (int j = i + i; j < arraySize; j = j + i)
                    {
                        numbers[j] = 0;
                    }
                }
            }

            int result = 0;
            int count = 0;
            for (int i = 2; i < arraySize; i++)
            {
                if (numbers[i] != 0)
                {
                    count++;
                    if (count == 10001)
                    {
                        result = numbers[i];
                    }
                }
            }

            TimeSpan elapsedTime = DateTime.Now - StartTime;

            Console.WriteLine("result: " + result.ToString());
            Console.WriteLine("elapsed time: " + elapsedTime.ToString("mm':'ss':'fff") + " mm:ss:fff");
            Console.ReadLine();
        }
    }
}

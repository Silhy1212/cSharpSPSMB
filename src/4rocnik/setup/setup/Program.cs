using System;

namespace setup
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                FizzBuzz(i);
            }
        }

        public static void FizzBuzz(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
}
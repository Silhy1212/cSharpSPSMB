using System;

namespace setup
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GuessNum guessNum = new GuessNum(1, 2);
            guessNum.RandNum();
            while (!guessNum.guessedNum)
            {
                
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

        public static void Inputnum()
        {
            string number = Console.ReadLine();
            
            
        }
    }
}
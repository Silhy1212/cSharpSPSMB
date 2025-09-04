using System;

namespace setup
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GuessNum guessNum = new GuessNum(1, 100);
            int randomNum = guessNum.RandNum();
            string RandomNum = randomNum.ToString();
            while (!guessNum.guessedNum)
            {
                string guessesNumber =guessNum.Inputnum();
                if (guessesNumber == RandomNum)
                {
                    Console.WriteLine("You win!");
                    Console.WriteLine("You guessed correctly!");
                    guessNum.guessedNum = true;
                }
                else
                {
                    Console.WriteLine("You lose!");
                    Console.WriteLine("You guessed the wrong number!");
                }
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
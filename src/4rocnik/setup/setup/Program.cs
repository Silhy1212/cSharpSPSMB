using System;
using System.Collections.Generic;
using System.Linq;

namespace setup
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           /* GuessNum guessNum = new GuessNum(1, 100);
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
            }*/

           Console.WriteLine(InputParse(Console.ReadLine()));
           
        }


        public static double Calculator(double num, double num2, string op)
        {
            switch (op)
            {
                case "+":
                    return num + num2;
                case "-":
                    return num - num2;
                case "/":
                    return num / num2;
                case "*":
                    return num * num2;
                case "**":
                    return Math.Pow(num, num2);
                default:
                    return 0;
            } 
        }

        public static double InputParse(string input)
        {
            List<string> blud = input.Split(' ').ToList();
            blud.RemoveAll(x => x == " ");
            return Calculator(double.Parse(blud[0]), double.Parse(blud[2]), blud[1]);
            
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
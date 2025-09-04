using System;
using Microsoft.Win32.SafeHandles;

namespace setup
{
    public class GuessNum
    {
        public int min;
        public int max;
        public bool guessedNum = false;

        public GuessNum(int min, int max)
        {
            this.min = min;
            this.max = max;
            
        }

        public int RandNum()
        {
            Random random = new Random();
            int num= random.Next(min,max);
            return num;
        }
        public string  Inputnum()
        {
            Console.WriteLine("Enter a number:");
            string number = Console.ReadLine();
            return number;
            
        }
    }
}
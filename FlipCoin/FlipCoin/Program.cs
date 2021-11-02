using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Practice_Programs
{
    class FlipCoin
    {
        public Random random = new Random();
        public double N;
        public double HeadCount = 0;
        public double TailCount = 0;
        public double HeadPercentage = 0;
        public double TailPercentage = 0;
        public int Count = 1;

        public void Coin()
        {
            Console.WriteLine("Enter the number of flips N ");
            N = Convert.ToInt32(Console.ReadLine());

            while (Count <= N)
            {
                int flipCheck = random.Next(0, 2);
                if (flipCheck == 1)
                {
                    Console.WriteLine("flip# " + Count + " is Head");
                    HeadCount++;
                }
                else
                {
                    Console.WriteLine("flip# " + Count + " is Tail");
                    TailCount++;
                }
                Count++;
            }
            Console.WriteLine("Number of times Head received is : " + HeadCount);
            Console.WriteLine("Number of times Tail received is : " + TailCount);
            HeadPercentage = 100 * HeadCount / N;
            TailPercentage = 100 * TailCount / N;
            Console.WriteLine("Head Percentage is: " + HeadPercentage);
            Console.WriteLine("Tail Percentage is: " + TailPercentage);
        }
    }
}
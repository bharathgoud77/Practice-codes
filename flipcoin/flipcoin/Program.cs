using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    public class HeadTail
    {

        public void PrintHeadTail()
        {
            int head = 0;
            int tail = 0;

            Random rand = new Random();
            Console.WriteLine("Enter the total number of tosses: ");
            int userInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < userInput; i++)
            {
                int key = rand.Next(0, 2);
                if (key == 0)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
            }

            double resultHead = (head * 100) / userInput;
            double resultTail = (tail * 100) / userInput;

            Console.WriteLine("Head % is " + resultHead);
            Console.WriteLine("Tail % is " + resultTail);
        }

    }
}

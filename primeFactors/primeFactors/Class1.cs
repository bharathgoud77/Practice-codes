using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalProgramme
{
    public class Prime
    {
        public void GetFactors()
        {
            Console.WriteLine("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());
            int i = 2;
            while (userInput > 1)
            {
                while (userInput % i == 0)
                {
                    Console.WriteLine(i);
                    userInput = userInput / i;
                }

                i++;
            }
            void Main(string[] args)
            {
                Console.WriteLine("prime = " + i);
            }
        }
    }
}
